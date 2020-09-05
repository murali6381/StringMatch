using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StringMatch.Models;
using StringMatch.Services;

namespace StringMatch.Controllers
{
    public class HomeController : Controller
    {
        private IStringMatchService _stringMatchService;
        
        public HomeController(IStringMatchService stringMatchService)
        {
            if (stringMatchService == null)
                throw new ArgumentNullException("stringMatchService");

            _stringMatchService = stringMatchService;
        }

        protected IStringMatchService StringMatchService
        {
            get
            {
                _stringMatchService = _stringMatchService ?? new StringMatchService();
                return _stringMatchService;
            }
            private set { _stringMatchService = value; }
        }

        public IActionResult Index()
        {
            return View();
        }


        //
        // POST: /Index
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(StringMatchViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.Output = StringMatchService.FindStartingIndex(
                model.Text ?? string.Empty,
                model.SubText ?? string.Empty);

            return View(model);
        }


    }
}
