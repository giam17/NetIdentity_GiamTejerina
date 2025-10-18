using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NetIdentity.Controllers
{
    [Authorize(Policy = "SoloFemeninoBool")]
    public class ActividadesController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Policy = "menoresEdad")]
        public IActionResult Deportes()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Tareas()
        {
            return View();
        }
    }
}
