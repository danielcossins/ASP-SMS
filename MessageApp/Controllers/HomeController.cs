using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio;

namespace MessageApp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            // Find your Account Sid and Auth Token at twilio.com/user/account 
            string AccountSid = "AC85f12f79e35f3ea3f1fb985df2ee99a9";
            string AuthToken = "ef3e7e352e393b144f8b74a2ed6c24af";
            var twilio = new TwilioRestClient(AccountSid, AuthToken);

            var message = twilio.SendMessage("+18017841260", "9132169521", "asdfsadfasdf", "");
            Console.WriteLine(message.Sid);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}