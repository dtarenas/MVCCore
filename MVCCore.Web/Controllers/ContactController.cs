using Microsoft.AspNetCore.Mvc;
using MVCCore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.Web.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return this.View(nameof(Index), contact);
            }

            return this.RedirectToAction(nameof(Thanks));
        }

        public IActionResult Thanks()
        {
            return this.View();
        }
    }
}
