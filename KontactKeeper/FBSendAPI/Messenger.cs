using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace FBSendAPI
{
    public class Messenger
    {
        public async Task SendMessageAsync(string fbid, string message)
        {
            var payload = new Body
            {
                Recipient = new Recipient
                {
                    res_id = fbid
                },
                Mesage = new Message
                {
                    message_body = message
                }

            };

            // Serialize our concrete class into a JSON String
            var stringPayload = await Task.Run(() => JsonConvert.SerializeObject(payload));

            // Wrap our JSON inside a StringContent which then can be used by the HttpClient class
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");

            using (var httpClient = new HttpClient())
            {

                // Do the actual request and await the response
                var httpResponse = await httpClient.PostAsync("https://graph.facebook.com/v9.0/me/messages?access_token=EAAFa9EpgZAdIBADyuV1M1mwl5QWleRLPjZCl5GuXCmZAMWJHTW2TkzlSPCDwi3pCJI2IZB9tGNuyQG5f447IXOVVMoyp3uS9FDucXrBiXVk3fXVofu4JpKgs8fOMrmChZBVB2KOg4TFZC2TmKZCUzqGBkA4FQDTKDlYCScWQvXmJVBrFpXwUabLq9ZBdbgeiSztKlLTa2ZCAoSwZDZD", httpContent);

                // If the response contains content we want to read it!
                if (httpResponse.Content != null)
                {
                    var responseContent = await httpResponse.Content.ReadAsStringAsync();

                    Console.WriteLine(responseContent);
                }
            }
        }
        public class Body
        {
            [JsonProperty("recipient")]
            public Recipient Recipient { get; set; }

            [JsonProperty("message")]
            public Message Mesage { get; set; }
        }

        public class Recipient
        {
            [JsonProperty("recipient")]
            public string res_id { get; set; }
        }
        public class Message
        {
            public string message_body { get; set; }
        }
    }
}
