using DI_Service_LifeTimes.Models;
using DI_Service_LifeTimes.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace DI_Service_LifeTimes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISingletonGuidService singleton1;
        private readonly ISingletonGuidService singleton2;
        private readonly ISingletonGuidService singleton3;
        private readonly IScopedGuidService scoped1;
        private readonly IScopedGuidService scoped2;
        private readonly IScopedGuidService scoped3;
        private readonly ITransientGuidService transient1;
        private readonly ITransientGuidService transient2;
        private readonly ITransientGuidService transient3;

        public HomeController(ILogger<HomeController> logger, ISingletonGuidService singleton1, ISingletonGuidService singleton2, ISingletonGuidService singleton3, IScopedGuidService scoped1, IScopedGuidService scoped2, IScopedGuidService scoped3, ITransientGuidService transient1, ITransientGuidService transient2, ITransientGuidService transient3)
        {
            _logger = logger;
            this.singleton1 = singleton1;
            this.singleton2 = singleton2;
            this.singleton3 = singleton3;
            this.scoped1 = scoped1;
            this.scoped2 = scoped2;
            this.scoped3 = scoped3;
            this.transient1 = transient1;
            this.transient2 = transient2;
            this.transient3 = transient3;
        }

        public IActionResult Index()
        {
            StringBuilder sb=new StringBuilder();
            sb.Append($"Transient1:- {transient1.GetGuid()}\n");
            sb.Append($"Transient2:- {transient2.GetGuid()}\n");
            sb.Append($"Transient3:- {transient3.GetGuid()}\n\n\n");

            sb.Append($"Scoped1:- {scoped1.GetGuid()}\n");
            sb.Append($"Scoped2:- {scoped2.GetGuid()}\n");
            sb.Append($"Scoped3:- {scoped3.GetGuid()}\n\n\n");

            sb.Append($"Singleton1:- {singleton1.GetGuid()}\n");
            sb.Append($"Singleton2:- {singleton2.GetGuid()}\n");
            sb.Append($"Singleton3:- {singleton3.GetGuid()}\n\n\n");
            return Ok(sb.ToString());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
