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

namespace Call.Controllers
{
    public class PhoneController : TwilioController
    {
        // GET: Phone
        public ActionResult Makecall()
        {
            var accountSid = "ACf1e06efe797a43090c3475f46ce8e848";
            var authToken = "435a618009fd61e725bba8dd849dfe81";
            TwilioClient.Init(accountSid, authToken);
            var to = new PhoneNumber("+918104032406");
            var from = new PhoneNumber("+14405776130");
            var call = CallResource.Create(
                to: to,
                from: from,
                url: new Uri("http://demo.twilio.com/docs/voice.xml"));
            return Content(call.Sid);
            //8433508262
        }
    }
}