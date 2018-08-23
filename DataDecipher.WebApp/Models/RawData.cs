using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace DataDecipher.WebApp.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RawData
    {
        public string ReadFile(string filePath)
        {
            string rawData = File.ReadAllText(filePath);
            string blogMessage = String.Join(Environment.NewLine, File.ReadLines(rawData));
            return "sample text";

        }

    }
}
