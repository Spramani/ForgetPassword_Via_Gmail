using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using gmail.Models;
using System.Net;
using System.Net.Mail;


namespace gmail.Controllers
{
    public class HomeController : Controller
    {
        socialnetworkEntities db = new socialnetworkEntities();
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

        // password reset 

        public ActionResult customerresetpassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult customerresetpassword(registration model)
        {
            using (var context = new socialnetworkEntities())
            {
                String mail = model.user_email;

                String pass = context.users.Where(x => x.user_email.Equals(model.user_email)).Select(x => x.user_password).FirstOrDefault();
                ViewBag.msg = "We Send Your Register Password in your Registered Email Address";

                var fromMail = new MailAddress("shubhramani901@gmail.com", "Social Network"); // set your email  
                var fromEmailpassword = "ramani901"; // Set your password   
                var toEmail = new MailAddress(mail);

                var smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(fromMail.Address, fromEmailpassword);

                var Message = new MailMessage(fromMail, toEmail);
                Message.Subject = "Password Forgot Request";
                Message.Body = "<br/> We Got Your email and Password." +
                               "<br/> please Remember this Login info and Login." +
                               "<br/><br/> Email : " + mail + "<br>" + "Password :" + pass;
                Message.IsBodyHtml = true;
                smtp.Send(Message);

            }
            return View();
        }



    }
}