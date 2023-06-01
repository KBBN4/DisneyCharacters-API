using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Disney_Characters_API.Models;
using static System.Net.WebRequestMethods;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Disney_Characters_API.Controllers
{
    public class DisneyController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index([FromQuery(Name = "url")] string resourceUrl = "http://api.disneyapi.dev/character")
        {
            var client = new HttpClient();


            var disneyUrl = resourceUrl;



            var disneyResponce = client.GetStringAsync(disneyUrl).Result;

            var disneyRoot = JsonConvert.DeserializeObject<DisneyRoot>(disneyResponce);
            return View(disneyRoot);

        }
        ////// obataining images from URl link == 2 ways?
        ////public IActionResult Images([FromQuery(Name = "url")] string resourceUrl = "http://api.disneyapi.dev/character")
        ////{
        ////    //    //var Images = DisneyDescription(resourceUrl);
        ////    //    //return View(Images);


        ////    if (resourceUrl.StartsWith("http://api.disneyapi.dev/character"))
        ////    {
        ////        var client = new HttpClient();

        ////        var url = resourceUrl;

        ////        var response = client.GetStringAsync(url).Result;

        ////        var root = JsonConvert.DeserializeObject<DisneyRoot>(response);

        ////        return View(root);
        ////    }
        ////    else
        ////    {
        ////        return View("Invalid Page");
        ////    }


        //}



        ////public IActionResult AnotherPage()
        ////{

        ////}
    }
}

