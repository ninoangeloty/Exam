using FPExam.Services;
using FPExam.Web.Models;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FPExam.Web.Controllers
{
    public class ExamController : Controller
    {
        public ActionResult Index()
        {
            var counter = this.CounterService.GetCount();

            return View(new ExamModel() { Counter = counter });
        }

        [HttpPost]
        public ActionResult Index(ExamModel model)
        {
            if (model.Counter > 10)
            {
                ModelState.Clear();
                model.Counter--;

                ModelState.AddModelError("Counter", "Value has reached the maximum number of 10.");
            }

            if (ModelState.IsValid)
            {
                this.CounterService.IncrementCount(model.Counter);
            }

            return View(model);
        }

        [Dependency]
        public ICounterService CounterService { get; set; }
    }
}