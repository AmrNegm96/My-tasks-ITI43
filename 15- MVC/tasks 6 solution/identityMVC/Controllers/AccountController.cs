using identityMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace identityMVC.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        Context context = new Context();
        // GET: Account
        public ActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Register(User usr)
        {
            //check if he is valid user (modelstate.isvalid)
            //inser new user to database
            //create user identity for this user using the claims (name,mail,password,phone)
            //owin cookie middleware , user identity to create cookie to this user to authenticate him
            //Redirect to Home/Index

            if (ModelState.IsValid)
            {
                context.Users.Add(usr);

                context.SaveChanges();
                var userIdentity = new ClaimsIdentity(new List<Claim>()
                {
                    new Claim("Name" , usr.Name),
                    new Claim(ClaimTypes.Email,usr.Email),
                    new Claim("Password",usr.Password),
                    new Claim("PhoneNumber" , usr.PhoneNumber)
                }, "AppCookie");

                //Get owin authentication manager 

                Request.GetOwinContext().Authentication.SignIn(userIdentity);

                return RedirectToAction("Index", "Home");
            }

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User usr)
        {
            //get user from DB
            //check user is not null 
            //if not null owin manager 
            //retrun view

            var loggedUser =
                context.Users.FirstOrDefault(u => u.Email == usr.Email && u.Password == usr.Password);
            if (loggedUser != null)
            {
                var SignInIdentity = new ClaimsIdentity(new List<Claim>(){
                        new Claim(ClaimTypes.Email,usr.Email),
                        new Claim("Password",usr.Password),
                    }, "AppCookie");
                Request.GetOwinContext().Authentication.SignIn(SignInIdentity);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("Email", "Email or password is not existing");
                return View();
            }


            //Get owin authentication manager 


        }
        public ActionResult Logout()
        {
            //remove cookie for this user

            Request.GetOwinContext().Authentication.SignOut("AppCookie");

            return RedirectToAction("Login");
        }
    }
}