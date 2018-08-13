﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data;
//using System.Data.DataSetExtensions;
using DataDecipher.WebApp.Models;
using System.Collections;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DataDecipher.WebApp.Controllers
{
    public class MethodController : Controller
    {
        public ActionResult Index()
        {
          

            List<MethodViewModel> methodList = new List<MethodViewModel>();

            var method1 = new MethodViewModel()
            {
                Method_Name = "Method1",
                Description = "Description1",
                Created_By = "Person1",
                Last_Modified_Date = "1/1/2001",
                Status = "Draft"
            };

            var method2 = new MethodViewModel()
            {
                Method_Name = "Method2",
                Description = "Description2",
                Created_By = "Person2",
                Last_Modified_Date = "2/2/2002",
                Status = "Completed"
            };
            var method3 = new MethodViewModel()
            {
                Method_Name = "Method3",
                Description = "Description2",
                Created_By = "Person2",
                Last_Modified_Date = "2/2/2002",
                Status = "Completed"
            };

            methodList.Add(method1);
            methodList.Add(method2);
            methodList.Add(method3);

            return View(methodList.AsEnumerable());
        }


        // GET: /<controller>/
        public ActionResult Index_with_datatable()
        {
            DataTable dt = new DataTable();

            var method1 = new MethodViewModel()
            {
                Method_Name = "Method1",
                Description = "Description1",
                Created_By = "Person1",
                Last_Modified_Date = "1/1/2001",
                Status = "Partial"
            };

            var method2 = new MethodViewModel()
            {
                Method_Name = "Method2",
                Description = "Description2",
                Created_By = "Person2",
                Last_Modified_Date = "2/2/2002",
                Status = "Completed"
            };

            var method3 = new MethodViewModel()
            {
                Method_Name = "Method3",
                Description = "Description2",
                Created_By = "Person2",
                Last_Modified_Date = "2/2/2002",
                Status = "Completed"
            };

            dt.Columns.Add(new DataColumn("Method_Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Description", typeof(string)));
            dt.Columns.Add(new DataColumn("Created_By", typeof(string)));
            dt.Columns.Add(new DataColumn("Last_Modified_Date", typeof(string)));
            dt.Columns.Add(new DataColumn("Status", typeof(string)));

            dt.Rows.Add(method1.Method_Name, method1.Description, method1.Created_By, method1.Last_Modified_Date, method1.Status);
            dt.Rows.Add(method2.Method_Name, method2.Description, method2.Created_By, method2.Last_Modified_Date, method2.Status);
            dt.Rows.Add(method3.Method_Name, method3.Description, method3.Created_By, method3.Last_Modified_Date, method3.Status);


            ViewData.Model = dt;

            return View();
        }


    }
}