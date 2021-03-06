﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDataGathering.Context;

namespace WebDataGathering.Controllers
{
    public class DataScrapeController : Controller
    {
         DataScrapeContext db = new DataScrapeContext();

        // GET: DataScrape
        public ActionResult Index()
        {
            return View(db.DataModels.ToList());
        }

        // GET: DataScrape/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DataScrape/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DataScrape/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DataScrape/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DataScrape/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DataScrape/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DataScrape/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
