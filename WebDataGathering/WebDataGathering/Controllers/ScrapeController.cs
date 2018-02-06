using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDataGathering.Models;

namespace WebDataGathering.Controllers
{
    public class ScrapeController : Controller
    {
        // GET: Scrape
        public RedirectToRouteResult Index()
        {
          DataScrape.StartScraper();
            //return View(ScrapeIndex);
            return RedirectToRoute("~/DataScrape/ScrapeIndex");
        }
    }
}