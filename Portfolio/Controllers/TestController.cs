using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class TestController : Controller
    {
        //public IActionResult Index()
        //{
        //    return Content("<h1>Hello World</h1>","text/html");
        //}

        public IActionResult Index()
        {
            //var fileByte = System.IO.File.ReadAllBytes("wwwroot/Files/4.docx");
            //const string fileName = "ducoments.docx";

            //return File(fileByte,MediaTypeNames.Application.Zip,fileName);


            //return Json(new
            //{
            //    name = "Mahdi",
            //    Family = "Khodadadi",
            //    age = 20,
            //});
            //var id = 12;
            //var id2 = "11;";
            //var ali = (id, id2);

            //return RedirectToAction("Index", ali);
            return new EmptyResult();
        }
    }

    //public class JavaScriptsResult : ContentResult
    //{
    //    public JavaScriptsResult(string data)
    //    {
    //        Content = data;
    //        ContentType = "application/javascript";
    //    }
    //}


}
