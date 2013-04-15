using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using LocalD.Data;
using LocalD.Templates.ApiResponses;
using Newtonsoft.Json;

namespace LocalD.Services
{
    public class UserApi
    {
        private readonly string _apiKey;
        private const string ApiVersion = "1/";
        private const string BaseUrl = "http://api.locald.co.uk/";

        public UserApi(string ApiKey)
        {
            _apiKey = ApiKey;
        }

        public async Task<LoginResponse> ApiLogin(string userPw, string userNm)
        {
            var x = JsonConvert.DeserializeObject<LoginResponseRootObject>(await HttpGet("user/login/" + "?key=" + _apiKey + "&username=" + userNm + "&password=" + userPw )).response;
            return x;
        }

        public async Task<RegisterResponse> ApiReg(string userPw, string userNm, string userMail, string userTownId)
        {
            var x = JsonConvert.DeserializeObject<RegisterResponseRootObject>(await HttpGet("user/register/" + "?key=" + _apiKey + "&username=" + userNm + "&password=" + userPw + "&email=" + userMail + "&town=" + userTownId)).response;
            return x;
        }

        public async Task<List<TownItem>> ApiTown()
        {
            var x = JsonConvert.DeserializeObject<TownResponseRootObject>(await HttpGet("town/?key=" + _apiKey)).response;
            return x;
        }

        public async Task<List<NewsItem>> ApiNews(string townId)
        {
            var x = JsonConvert.DeserializeObject<NewsResponseRootObject>(await HttpGet("news/find/" + "?key=" + _apiKey + "&town=" + townId)).response;
            return x;
        }

        private async Task<string> HttpGet(string urlAppend)
        {
            var request = (HttpWebRequest)WebRequest.Create(BaseUrl + ApiVersion + urlAppend );
            var response = await request.GetResponseAsync();

            string temp;

            using (var stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream))
                temp = reader.ReadToEnd();
            return temp;
        }
    }
}
