using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollectionSort.Controllers
{
    public class NumsController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            List<int> numbers = new List<int>();
            Random rnd = new Random();

            for (int counter = 1; counter <= 5; counter++)
            {                
                int num = rnd.Next(50);
                numbers.Add(num);
            }

            numbers.Sort();

            ViewBag.Numbers = numbers;          
            return View();
        }
    }
}