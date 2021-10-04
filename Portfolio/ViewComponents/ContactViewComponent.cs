using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Portfolio.Models;

namespace Portfolio.ViewComponents
{
    public class ContactViewComponent:ViewComponent
    {

        private readonly List<Service> _services = new List<Service>
        {
            new Service(1,"مسابقه"),
            new Service(2,"مشاوره "),
            new Service(3,"معامله "),
            new Service(4,"معاوضه"),
        };


        public IViewComponentResult Invoke()
        {
            var model = new ContactMe()
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            ViewData["Contact"] = "تماس با من";

            return View("/Views/Home/Components/Contact/Contact.cshtml",model);
        }
    }
}
