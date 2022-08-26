using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XssDemo.Models
{
    public class Emp
    {
        [AllowHtml]
        public string Name { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
    }
}