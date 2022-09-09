using Microsoft.AspNetCore.Mvc;
using MVCProgams.Models;
using MVCProgams.Services;

namespace MVCProgams.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = PizzaServices.GetAll();
            return View(pizzas);
        }

        public IActionResult Detail(int id)
        {
            Pizza p = PizzaServices.Get(id);
            return View(p);
        }
        public IActionResult List( int id)

        {
            List<Pizza> pizzas = PizzaServices.GetAll();
            return View(pizzas);
        }
    }
}