using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestFinaleLucaMVC.Models;

namespace TestFinaleLucaMVC.Controllers {
	public class HomeController : Controller {
		public ActionResult Index() {
			return View();
		}

		public ActionResult About() {
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact() {
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult Pranzo() {
			ViewBag.Messagge = "Benvenuto nella pagina per aggiungere il pranzo";
			return View("Pranzo");
		}
		[HttpPost]
		public ActionResult Pranzo(string primo, string secondo, string contorno, string dolce) {
			DomainModel dm = new DomainModel();
			dm.AddPranzo(primo, secondo, contorno, dolce);
			ViewBag.primo = primo;
			ViewBag.secondo = secondo;
			ViewBag.contorno = contorno;
			ViewBag.dolce = dolce;
			return View("Pranzo");
		}
	}
}