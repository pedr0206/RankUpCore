using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RankUpCore.Models;

namespace RankUpCore.Controllers
{
    public class JobAdController : Controller
    {
        JobRepository jobRepository = JobRepository.Instance;
        
        // GET: JobAd
        [HttpGet]
        public ActionResult Index()

        {
            Job job = new Job();
            return View(job);
        }

        [HttpPost]
        public ActionResult Index([FromForm]Job job)
        {
            if (ModelState.IsValid)
            {
                
                jobRepository.AddJob(job);

            }
            return RedirectToAction("AllJobs");
        }
        [HttpGet]
        // GET: JobAd/Details/5
        public ActionResult AllJobs()
        {
            
            return View(jobRepository.GetAll());
        }

        // GET: JobAd/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JobAd/Create
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

        // GET: JobAd/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JobAd/Edit/5
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

        // GET: JobAd/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JobAd/Delete/5
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