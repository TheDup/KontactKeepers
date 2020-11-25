using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Net.Http;

namespace FBSendAPI
{
    public class Messenger
    {
        public async Task SendMessage(string fbid, string message)
        {
            WebRequest request = WebRequest.Create("https://graph.facebook.com/v9.0/me/messages?access_token=EAAFa9EpgZAdIBAPZAOxwmopn8gBdvU7EwQJJ6FyLgDP1asd0NCQzkHZBEozlJORiEZAt1DutjcI0MUUo9nnaqGZB69jXFxJ66XesU7sccpqsVrEPovOtkBls12rb7p2VeiCoCzJG7rZCXCEyPVDGoUSf0chwRFwCxTWkJ1bCwpPKBWt9dJ5xN7");
            request.Method = "POST";


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
            var stringPayload = await Task.Run(() => JsonConvert.SerializeObject(payload));


            string postData = stringPayload;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/json";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;

            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();

            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            // Get the stream containing content returned by the server.
            // The using block ensures the stream is automatically closed.
            using (dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                Console.WriteLine(responseFromServer);
            }

            // Close the response.
            response.Close();
            Console.ReadLine();
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
        [JsonProperty("id")]
        public string res_id { get; set; }
    }
    public class Message
    {
        [JsonProperty("text")]
        public string message_body { get; set; }
    }
}

