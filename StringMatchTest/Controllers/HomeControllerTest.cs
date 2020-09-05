using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringMatch;
using StringMatch.Controllers;
using Microsoft.AspNetCore.Mvc;
using StringMatch.Services;
using StringMatch.Models;

namespace TextMatch.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {


        [TestMethod]
        public void Index()
        {

            IStringMatchService _stringMatchService;
            _stringMatchService = new StringMatchService();

            HomeController controller = new HomeController(_stringMatchService);

            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void IndexWithInvalidModel()
        {

            IStringMatchService _stringMatchService;
            _stringMatchService = new StringMatchService();

            HomeController controller = new HomeController(_stringMatchService);
            StringMatchViewModel model = new StringMatchViewModel();

            ViewResult result = controller.Index(model) as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void IndexWithValidModel()
        {
            
            IStringMatchService _stringMatchService;
            _stringMatchService = new StringMatchService();

            HomeController controller = new HomeController(_stringMatchService);
            StringMatchViewModel model = new StringMatchViewModel();
            model.Text = "Murali";
            model.SubText = "ra";
           
            ViewResult result = controller.Index(model) as ViewResult;
           
            Assert.IsNotNull(result);
            Assert.AreEqual("3",((StringMatchViewModel)result.Model).Output);
        }

        [TestMethod]
        public void IndexWithValidEmptyModel()
        {

            IStringMatchService _stringMatchService;
            _stringMatchService = new StringMatchService();

            HomeController controller = new HomeController(_stringMatchService);
            StringMatchViewModel model = new StringMatchViewModel();
            model.Text = "";
            model.SubText = "";

            ViewResult result = controller.Index(model) as ViewResult;

            Assert.IsNotNull(result);

        }
    }
}
