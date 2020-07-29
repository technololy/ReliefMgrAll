using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SterlingMobile.Services
{
    public class APIService
    {
        static string ipAcctOpen;
        private static HttpClient client = new HttpClient();
        


        public APIService()
        {
            ipAcctOpen = "http://localhost:44382/";
            client = new HttpClient();
            //client.DefaultRequestHeaders.Add("ApiKey", Settings.AppSettings.CamsAccountOpeningKey);
            client.MaxResponseContentBufferSize = 2147483647;

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue
                                                    ("application/json"));

        }
        public  async Task<T> Post<T>(object model, string endPoint, CancellationTokenSource cancellation = null, string contentType = "application/json")
        {
            try
            {
                string json = string.Empty;
                string url = $"{ipAcctOpen}{endPoint}";
                //if (client==null)
                //{
                //    client = new HttpClient();
                //}
                json = JsonConvert.SerializeObject(model);
                System.Diagnostics.Debug.WriteLine(json);
                var stringContent = new StringContent(json, Encoding.UTF8, contentType);
                

                if (cancellation == null)
                    cancellation = new CancellationTokenSource();
                var message = await client.PostAsync(url, stringContent);
                var content = await message.Content.ReadAsStringAsync();
                System.Diagnostics.Debug.WriteLine(content);

                var response = JsonConvert.DeserializeObject<T>(content);
          
                return response;

            }
            catch (Exception ex)
            {

                return default;
            }

        }






        internal  async Task<T> Get<T>(string method, bool cacheData = false, int cacheDurationHours = 24, bool forceRefresh = false, CancellationTokenSource cancellation = null, string contentType = "application/json")
        {


            try
            {
                string url;
                url = ipAcctOpen + method;
                var json = string.Empty;
                T deserialize = default(T);


                if (string.IsNullOrWhiteSpace(json))
                {
                    HttpResponseMessage res = new HttpResponseMessage();
                

                    res = await client.GetAsync(url).ConfigureAwait(false);
                    json = await res.Content.ReadAsStringAsync();
                    System.Diagnostics.Debug.WriteLine(json);



                    deserialize = JsonConvert.DeserializeObject<T>(json);
                }
                else
                {
                    deserialize = JsonConvert.DeserializeObject<T>(json);
                }

                return deserialize;
            }
            catch (Exception ex)
            {
                return default;


            }

        }


    }
}
