﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using HNBMG.Models.Pages;

namespace HNBMG.Controllers
{
    public class HnbmgPageController : PageController<HnbmgPage>
    {
        public ActionResult Index(HnbmgPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            var repository = EPiServer.ServiceLocation.ServiceLocator.Current.GetInstance<IContentRepository>();
            ContentReference pageLink = ContentReference.StartPage;
            IEnumerable<InfoPage> pages = repository.GetChildren<InfoPage>(pageLink);
            ViewBag.children = pages;
            return View(currentPage);
        }
    }
}