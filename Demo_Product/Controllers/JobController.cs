﻿using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramewok;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Job.Controllers
{
    public class JobController : Controller
    {

        JobManager jobManager = new JobManager(new EfJobDal());
        public IActionResult Index()
        {
            var values = jobManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddJob()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddJob(Job P)
    {
            jobManager.TInsert(P);
            return RedirectToAction("Index");
          
        }

        public IActionResult DeleteJob(int id)
        {
            var value = jobManager.TGetById(id);
            jobManager.TDelete(value);

            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult UpdateJob(int id)
        {
            var value = jobManager.TGetById(id);

            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateJob(Job p)
        {
            jobManager.TUpdate(p);

            return RedirectToAction("Index");
        }
    }
}
