using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class ContactViewComponent:ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            ViewData["Contact"] = "تماس با من";

            return View("/Views/Home/Components/Contact/Contact.cshtml");
        }
    }
}
