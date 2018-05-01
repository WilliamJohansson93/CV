using CV.Models;
using CV.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace CV.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //STORES A LIST OF EDUCATION
            var listOfEducation = PersonalInformation.EducationInfo();
            //STORES A LIST OF WORK EXPERIENCE
            var listOfWorkExperience = PersonalInformation.WorkExperience();
            //EmailSentSuccess HAS TO BE FALSE SO THAT MODAL DOES NOT APPEAR (THE ONE YOU WILL GET ONCE YOU SEND AN EMAIL)
            var viewModel = new PersonalInformationViewModel()
            {
                EmailSentSuccess = false,
                Education = listOfEducation,
                WorkExperience = listOfWorkExperience
            };
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Index(string FullName, string phoneNumber, string email, string password, string profession, string CompanyName, string cAddress, string message)
        {
            //Message
            var body = "<p>Company: {0} ({1})</p><p>From: {2}</p><p>Looking for a: {3}<p>Phone Number: {4}</p></p><p>Message: {5}</p>";
            var emailMessage = new MailMessage();
            //THE RECIPIENT OF THE EMAIL
            emailMessage.To.Add(new MailAddress("WilliamJohansson93@hotmail.com"));
            //THE SENDERS EMAIL
            emailMessage.From = new MailAddress(email);
            //IF THE SENDER CHOOSES NOT TO WRITE THEIR PHONENUMBER
            if (phoneNumber == "")
            {
                phoneNumber = "Phone number was not specified.";
            }
            //IF THEY CHOSE NOT TO SELECT ANY SPECIFIC PROFESSION
            if (profession == "")
            {
                emailMessage.Subject = "Sent from Williams' Contact Form";
                profession += "No Profession Selected";
            }
            //IF THEY CHOSE A PROFESSION
            else
            {
                emailMessage.Subject = "Looking for a " + profession;
            }
            //COMPLETING THE BODY STRING WITH ADDED VARIABLES
            emailMessage.Body = string.Format(body, CompanyName, FullName, email, profession, phoneNumber, message);
            emailMessage.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                //SENDS AN EMAIL FROM SPECIFIED EMAIL-ACCOUNT (PASSWORD IS NEEDED) 
                var credential = new NetworkCredential
                {
                    UserName = email,
                    Password = password
                };
                smtp.Credentials = credential;
                //WILL USE GMAIL-HOST IF EMAIL-ACCOUNT CONTAINS THE WORD '@GMAIL.'
                if (email.Contains("@gmail."))
                {
                    smtp.Host = "smtp.gmail.com";
                }
                //IF NOT - WILL USE HOTMAIL.COM
                else
                {
                    smtp.Host = "smtp-mail.outlook.com";
                }
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(emailMessage);
            }
            //STORES A LIST OF EDUCATION
            var listOfEducation = PersonalInformation.EducationInfo();
            //STORES A LIST OF WORK EXPERIENCE
            var listOfWorkExperience = PersonalInformation.WorkExperience();
            //A CONFIRMATION MODAL WILL APPEAR ONCE THE EMAIL HAS BEEN SENT SUCCESFULLY WITH ALL OF THE INFORMATION UNDERNEATH
            var viewModel = new PersonalInformationViewModel()
            {
                cAddress = cAddress,
                CompanyName = CompanyName,
                Email = email,
                FullName = FullName,
                Message = message,
                PhoneNumber = phoneNumber,
                Profession = profession,
                EmailSentSuccess = true,
                Education = listOfEducation,
                WorkExperience = listOfWorkExperience
            };
            return View(viewModel);
        }
        //ANGULAR CALLS ON GETPERSONALINFORMATION TO GET ALL OF THE PERSONAL INFORMATION (NOT WORK EXPERIENCE OR EDUCATION)
        public JsonResult GetPersonalInformation()
        {
            //ALL OF THE PERSONALINFO VIA PERSONALINFORMATION CLASS > PERSONALINFO METHOD
            var MyPersonalInfo = PersonalInformation.PersonalInfo();
            //RETURNS PERSONALINFO
            return Json(MyPersonalInfo, JsonRequestBehavior.AllowGet);
        }
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}