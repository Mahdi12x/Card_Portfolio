using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.ViewComponents
{
    public class MeViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var profile = new Me("محسن خدادادی", "سرمایه گذار و مربی ورزشی");

            return View("/Views/Home/Components/Me/Me.cshtml",profile);
        }


    }
}
