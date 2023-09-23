using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCAppDemo.Controllers
{
    public class DemoController : Controller
    {
        // GET: DemoController
        public ActionResult Start()
        {
            return View();
        }
       
    }
}
