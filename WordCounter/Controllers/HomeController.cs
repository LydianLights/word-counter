using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
    }
}
