using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCAppDemo.Controllers
{
    public class PartialViewController : Controller
    {
        // GET: PartialViewController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tabs()
        {
            ViewData["data1"] = "Tom and Jerry are Good Friends";
            return View();
        }
        
    }
}
