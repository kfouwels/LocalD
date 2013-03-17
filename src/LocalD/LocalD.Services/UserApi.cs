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
        private const string baseUrl = "http://api.locald.co.uk/1/";

        public delegate void DownloadCompleteDelegate(string returnValue);
        public event DownloadCompleteDelegate DownloadCompleted;

        public UserApi(string ApiKey)
        {
            this.ApiKey = ApiKey;
        }

        public async Task<LoginResponse> ApiLogin(string userPw, string userNm)
        {
            var x = await HttpGet("user/register/" + "?key=" + ApiKey + "&username=" + userNm + "&password=" + userPw );
        }

        public async Task ApiReg(string userPw, string userNm, string userMail, string userTown)
        {

            await HttpGet("user/register/"  +
                            "?key="         +   ApiKey + 
                            "&username="    +   userNm + 
                            "&password="    +   userPw + 
                            "&email="       +   userMail + 
                            "&town="        +   userTown
                        );

        }

        public async Task ApiTown()
        {
            FilingCabinet.TownsList = JsonConvert.DeserializeObject<TownResponseRootObject>(await HttpGet("town/?key=" + ApiKey)).response;
        }

        private async Task<string> HttpGet(string urlAppend)
        {
            var request = (HttpWebRequest)WebRequest.Create(baseUrl + urlAppend );
            var response = await request.GetResponseAsync();

            string temp;

            using (var stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream))
                temp = reader.ReadToEnd();
            return temp;
        }
    }
}
