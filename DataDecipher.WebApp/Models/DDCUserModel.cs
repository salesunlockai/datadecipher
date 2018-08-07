using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations; 

namespace DataDecipher.WebApp.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class DDCUserModel
    {
        [Required(ErrorMessage = "UserName is required")]  
        public string UserName { get; set; }  
        [Required(ErrorMessage = "Password is required")]  
        [DataType(DataType.Password)]  
        public string Password { get; set; }


        public string IsAuthenticated(string username, string password)
        {
            if((username != "admin") || (password != "admin"))
            {
                return "Login Failed";
            }
            return "Successful";
        }
    }
}
