using MultiLanguageYeniCodeFirst.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultiLanguageYeniCodeFirst.Controllers
{
    public class HomeController : MyBaseController
    {
        MultiContext context = new MultiContext();

        public ActionResult Index()
        {
            HttpCookie langCookie = Request.Cookies["culture"];
            if (langCookie.Value == "tr")
            {
                return View(context.Yazis.Where(y => y.Language.LanguageCode.Equals("tr")).ToList());
            }
            else
                return View(context.Yazis.Where(y => y.Language.LanguageCode.Equals("en")).ToList());
        }

        public ActionResult ChangeLanguage(string lang)
        {
            new SiteLanguage().SetLanguage(lang);
            return RedirectToAction("Index", "Home");
            //return Redirect(Request.UrlReferrer.PathAndQuery);

        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}