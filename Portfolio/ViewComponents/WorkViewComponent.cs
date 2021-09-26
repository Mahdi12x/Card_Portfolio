using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.ViewComponents
{
    public class WorkViewComponent:ViewComponent
    {


        public IViewComponentResult Invoke()
        {
            var imageAddress = new List<Work>()
            {
                new Work("pic01.jpg"),
                new Work("pic02.jpg"),
                new Work("pic03.jpg"),
                new Work("pic04.jpg"),
                new Work("pic05.jpg"),
                new Work("pic06.jpg"),
                new Work("pic07.jpg"),
                new Work("pic08.jpg")
            };
            

            return View("~/Views/Home/Components/Work/Work.cshtml",imageAddress);
        }
    }
}
