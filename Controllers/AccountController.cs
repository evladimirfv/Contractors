    using System;  
    using System.Collections.Generic;  
    using System.Linq;  
    using System.Security.Claims;  
    using System.Threading.Tasks;  
    using Microsoft.AspNetCore.Authentication;  
    using Microsoft.AspNetCore.Authentication.Cookies;  
    using Microsoft.AspNetCore.Mvc;  
      
    namespace CookieDemo.Controllers  
    {  
        public class AccountController : Controller  
        {  
            public IActionResult Login()  
            {  
                return View();  
            }  
      
            [HttpPost]  
            public IActionResult Login(string userName, string password)  
            {  
                if(!string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(password))  
                {  
                    return RedirectToAction("Login");  
                }  
      
                //Check the user name and password  
                //Here can be implemented checking logic from the database  
      
                if(userName=="Compania" && password == "password"){  
      
                    //Create the identity for the user  
                    var identity = new ClaimsIdentity(new[] {  
                        new Claim(ClaimTypes.Name, userName)  
                    }, CookieAuthenticationDefaults.AuthenticationScheme);  
      
                    var principal = new ClaimsPrincipal(identity);  
      
                    var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);  
      
                    return RedirectToAction("Compania", "Compania");  
                }  


                if(userName=="Cliente" && password == "password"){  
      
                    //Create the identity for the user  
                    var identity = new ClaimsIdentity(new[] {  
                        new Claim(ClaimTypes.Name, userName)  
                    }, CookieAuthenticationDefaults.AuthenticationScheme);  
      
                    var principal = new ClaimsPrincipal(identity);  
      
                    var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);  
      
                    return RedirectToAction("Cliente", "Cliente");  
                } 


                 if(userName=="Profesional" && password == "password"){  
      
                    //Create the identity for the user  
                    var identity = new ClaimsIdentity(new[] {  
                        new Claim(ClaimTypes.Name, userName)  
                    }, CookieAuthenticationDefaults.AuthenticationScheme);  
      
                    var principal = new ClaimsPrincipal(identity);  
      
                    var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);  
      
                    return RedirectToAction("Profesional", "Profesional");  
                } 


      
                return View();  
            }  
        }  
    }  