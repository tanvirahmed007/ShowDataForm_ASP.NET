using Microsoft.AspNetCore.Mvc;
using ShowDataForm.Models;

namespace ShowDataForm.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(CreateCustomer create)
        {
            return View(create);
        }
    }
}
