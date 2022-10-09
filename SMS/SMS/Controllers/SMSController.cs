using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Twilio.TwiML;
using Twilio.AspNet.Mvc;

namespace SMS.Controllers
{
    public class SMSController : TwilioController
    {
        // GET: SMS
        public ActionResult SendSms()
        {
            Random rn = new Random(999999);
            int otp = rn.Next();
            var accountSid = "ACf1e06efe797a43090c3475f46ce8e848";
            var authToken = "435a618009fd61e725bba8dd849dfe81";


            TwilioClient.Init(accountSid, authToken);
            var to = new PhoneNumber("+919819648674");
            var from = new PhoneNumber("+14405776130");
            var message = MessageResource.Create(
                to: to,
                from: from,
               body: " Hi Examiner! Hope you liked our presentation, here's your OTP :" + otp);
            return Content(message.Sid);
        }
    }
}