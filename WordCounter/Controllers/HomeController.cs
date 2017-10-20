using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WordCounter.ViewModels.Home;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        IndexModel model = new IndexModel();
        return View(model);
      }

      [HttpPost("/results"), ActionName("Index")]
      public ActionResult Submit()
      {
        string inputSentence = Request.Form["input-sentence"];
        string inputWord = Request.Form["input-word"];
        
        IndexModel model = new IndexModel(inputSentence, inputWord);
        return View(model);
      }
    }
}
