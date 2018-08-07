using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataDecipher.WebApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DataDecipher.WebApp.Controllers
{
    public class ValidateLogin : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(string Username, string Password)
        {
            //TODO: Add login code here
            DDCUserModel credentials = new DDCUserModel();
            string validationResult = credentials.IsAuthenticated(Username, Password);

            if(validationResult == "Successful")
            {
                return View("/Views/Main/Index.cshtml");
            }
            ViewData["Message"] = "Login Failed";

            return View("/Views/Login/Index.cshtml");
        }
    }
}
