using System;
using System.Web.Mvc;

namespace WebCI.Javascript.Tests.Controllers
{
    public class JasmineController : Controller
    {
        public ViewResult Run()
        {
            return View("SpecRunner");
        }
    }
}
