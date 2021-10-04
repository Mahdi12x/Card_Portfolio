using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new List<Service>
        {
            new Service(1,"مسابقه"),
            new Service(2,"مشاوره "),
            new Service(3,"معامله "),
            new Service(4,"معاوضه"),
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {

            return View("Components/Contact/Contact");
        }


        [HttpPost]
        public IActionResult Contact(ContactMe contact)
        {
          
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "لطفا اطلاعات را به صورت صحیح پر کنید";
                return View("Components/Contact/Contact",contact);

            }
            ModelState.Clear();
            var model = new ContactMe()
            {
                Services = new SelectList(_services,"Id","Name")
            };

            ViewBag.Success = "پیام شما موفقیت آمیز ارسال شد";
            return View("Index");
        }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
