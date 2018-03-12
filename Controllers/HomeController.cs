using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace MvcGlobalizacion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(String cultura)
        {
            if (cultura != null)
            {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultura);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);
            int i = 100; //Un número de monedas
            CultureInfo moneda = new CultureInfo(cultura);
            ViewBag.Symbol = i.ToString("c", moneda);
            }
            ViewBag.Bienvenido = Resources.Resource.Bienvenido;
            ViewBag.Flag = Resources.Resource.Flag;
            return View();
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