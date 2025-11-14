using BeeBuzz.Data;
using Microsoft.AspNetCore.Mvc;

namespace BeeBuzz.Controllers.Base
{
    public class OrganizationController : Controller
    {

        private readonly ILogger<OrganizationController> _logger;
        private IUnitOfWork _unitOfWork;
        public IActionResult Index()
        {
            return View();
        }
    }
}
