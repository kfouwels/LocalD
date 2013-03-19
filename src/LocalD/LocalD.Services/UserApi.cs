using System;
using System.Collections.Generic;
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
        private readonly string ApiKey;
        private const string apiVersion = "1/";
        private const string baseUrl = "http://api.locald.co.uk/";

        public UserApi(string ApiKey)
        {
            this.ApiKey = ApiKey;
        }

        public async Task<LoginResponse> ApiLogin(string userPw, string userNm)
        {
            var x = JsonConvert.DeserializeObject<LoginResponseRootObject>(await HttpGet("user/login/" + "?key=" + ApiKey + "&username=" + userNm + "&password=" + userPw )).response;
            return x;
        }

        public async Task<RegisterResponse> ApiReg(string userPw, string userNm, string userMail, string userTown)
        {
            var x = JsonConvert.DeserializeObject<RegisterResponseRootObject>(await HttpGet("user/register/" + "?key=" + ApiKey + "&username=" + userNm + "&password=" + userPw + "&email=" + userMail + "&town=" + userTown)).response;
            return x;
        }

        public async Task<List<TownResponse>> ApiTown()
        {
            var x = JsonConvert.DeserializeObject<TownResponseRootObject>(await HttpGet("town/?key=" + ApiKey)).response;
            return x;
        }

        private async Task<string> HttpGet(string urlAppend)
        {
            var request = (HttpWebRequest)WebRequest.Create(baseUrl + apiVersion + urlAppend );
            var response = await request.GetResponseAsync();

            string temp;

            using (var stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream))
                temp = reader.ReadToEnd();
            return temp;
        }
    }
}
