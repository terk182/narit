using App.EDU.Responses;
using App.GL.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App.EDU
{
    public class EDUServices : IEDUServices
    {
        private readonly string? _webAPIBaseUrl;
        protected string? _accessToken;
        private readonly string? connecttion;
        public EDUServices( string webAPIBaseUrl = "http://192.168.2.221:3000")
        {
       
            _webAPIBaseUrl = webAPIBaseUrl;
           
        }


        public async Task<loginResponse> LoginCgiEduApi(loginRequest request)
        {
            CheckIfTokenIsValid();
            try
            {
                using (var client = CreateClient())
                {

                    var fullPath = $"{_webAPIBaseUrl}/auth/login";

                    var response = await client.PostAsync(fullPath, new JsonContent(request));

                    var s = await response.Content.ReadAsStringAsync();

                    if (response.StatusCode == HttpStatusCode.Created)
                    {

                        var result =  JsonConvert.DeserializeObject<loginResponse>(s);
                        return result;


                    }
                }
            }
            catch (Exception ex)
            {
                //
            }
            return null;
           
        }
        public HttpClient CreateClient()
        {
            var client = new HttpClient();
            //client.DefaultRequestHeaders.Add("x-api-key", _payment2C2PPoll.SecretKey);

            return client;
        }
        public void CheckIfTokenIsValid()
        {
            //if (string.IsNullOrWhiteSpace(_payment2C2PPoll.SecretKey))
            //{
            //    throw new Exception("There is no access token currently loaded to access the Line." +
            //        "Please load a new access token and try again");
            //}
        }

        public async Task<StudentResponse> student(string q)
        {
            CheckIfTokenIsValid();
            try
            {
                using (var client = CreateClient())
                {

                    var fullPath = $"{_webAPIBaseUrl}/student?q={q}";

                    var response = await client.GetAsync(fullPath);

                    var s = await response.Content.ReadAsStringAsync();

                    if (response.StatusCode == HttpStatusCode.OK)
                    {

                        var result = JsonConvert.DeserializeObject<StudentResponse>(s);
                        return result;


                    }
                }
            }
            catch (Exception ex)
            {
                //
            }
            return null;
           
        }

        public class JsonContent : StringContent
        {
            public JsonContent(object obj)
                : base(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json")
            {

            }
        }
    }
}
