using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ServiceStack.Redis;

namespace RedisLinkedContainer.Controllers
{
    public class HomeController : Controller
    {

        string key = "message";
        public IActionResult Index()
        {         

            string db = Environment.GetEnvironmentVariable("REDIS_PORT_6379_TCP_ADDR");

            //Pull to show count
            using (RedisClient client = new RedisClient(db))
            {
                client.Set<string>(key, "Hello World from Redis!");

                string x = client.Get<string>(key);

                ViewBag.Message = x;

            }

            //Return Dictionary of all environment variables
            var all = Environment.GetEnvironmentVariables();
            return View(all);
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
