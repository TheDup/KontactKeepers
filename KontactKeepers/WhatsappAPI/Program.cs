using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace WhatsAppSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            //IWebDriver driver = new ChromeDriver();
            ////driver.Url = "https://www.google.com/advanced_search";
            //driver.Url = "https://web.whatsapp.com/";
            //driver.Manage().Window.Maximize();

            //Getting Twilio account SID and AuthToken
            TwilioClient.Init(
                TwilioHelper.Twillio_Accont_SID, //This is supposed to be the username property
                TwilioHelper.Twilio_Auth_Token //auth token provided by twilio
                );

            //Create message resource
            var message = MessageResource.Create(
                To: TwilioHelper.Personal.Phone_Number, //To whom you're sending the message to
                from: TwilioHelper.Twilio_phone_number,
                body: "Hello, this is a test message"
           );
            //log message id to nsure message was sent succsessfully
            Console.WriteLine($"message:id {message.Sid}");
            Console.ReadLine();
        }
   
    }
}
