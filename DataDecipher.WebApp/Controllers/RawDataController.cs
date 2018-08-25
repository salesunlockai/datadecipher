using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataDecipher.WebApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DataDecipher.WebApp.Controllers
{
    public class RawDataController : Controller
    {
        // GET: /<controller>/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DisplayRawData(string inputSelectedFile)
        {
            var model1 = new RawDataModel
            {
                //filePath = "TestData/GC2.DAT"
                fileName = inputSelectedFile,
                filePath = "TestData/" + inputSelectedFile
            };
            model1.rawData = model1.GetRawData(model1.filePath);

            return View(model1);
        }
    }
}
