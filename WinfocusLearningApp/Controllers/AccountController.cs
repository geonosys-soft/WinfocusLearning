using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WinfocusLearningApp.Models;

namespace WinfocusLearningApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login() { 
            LoginModel inf=new LoginModel();
            inf.Username = "admin";
            inf.Password = "1234";
           if(inf.Username=="admin" && inf.Password=="123")
            {
                FormsAuthentication formsAuthentication = new FormsAuthentication();    

            }
        return View();
        }
    }
}