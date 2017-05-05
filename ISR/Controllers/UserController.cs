using ISR.Models;
using ISR.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISR.Controllers
{
    public class UserController : Controller
    {
        
        public ActionResult Registration()
        {
            if(Session["email"] != null)
            {
                return RedirectToAction("Question");
            }
            return View();
        }

        public ActionResult Question()
        {
            ViewBag.Email = Session["email"].ToString();
            return View();
        }

        [HttpPost]
        public ActionResult Registration(User user)
        {
            UserService us = new UserService();
            us.AddUser(user);
            TempData["RegisterSucces"] = user.Login;
            return RedirectToAction("RegisterSucces"); 
        }

        public ActionResult RegisterSucces()
        {
            ViewBag.Login = TempData["RegisterSucces"];
            return View();
        }

        public ActionResult Login()
        {
            if (Session["email"] != null)
            {
                return RedirectToAction("Question");
            }
            return View();
        }

        [HttpPost]
        public String Login(User user)
        {

            UserService us = new UserService();
            User reciveUser = us.GetUser(user);
            Session["email"] = reciveUser.Email.ToString();
            return "Pobrano urzytkownika o Loginie: " + reciveUser.Login + ", który posiada mail: " + reciveUser.Email;
        }

        public ActionResult Loginout()
        {
            Session.Abandon();
            return View();
        }
    }
}