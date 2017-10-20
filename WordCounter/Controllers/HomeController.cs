using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WordCounter.Models;
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

      [HttpPost("/"), ActionName("Index")]
      public ActionResult Submit()
      {
        string inputSentence = Request.Form["input-sentence"];
        string inputWord = Request.Form["input-word"];
        int numMatches = MatchFinder.CountMatches(inputSentence, inputWord);

        IndexModel model = new IndexModel(numMatches);
        return View(model);
      }
    }
}
