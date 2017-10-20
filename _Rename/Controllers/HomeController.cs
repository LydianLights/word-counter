using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using _Rename.Models;

namespace _Rename.Controllers
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
