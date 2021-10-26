using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tp09.Models;

namespace tp09.Controllers
{
    public class HomeController : Controller
    {
        // private Pizza Pizza;

        public IActionResult Index()
        {
            ViewBag.Pizzas = Pizzeria.ListarPizzas();

            return View();
        }
        
        public IActionResult VerPizza(int id)
        {
            ViewBag.Pizza = Pizzeria.ListarPizzas().FirstOrDefault(p => p.Id == id);
            return View("DetallePizza");
        }

        public IActionResult AgregarPizza()
        {
            ViewBag.Ingredientes = Pizzeria.ListarIngredientes();
            return View();
        }

        [HttpPost]
        public IActionResult GuardarPizza(string nombre, double precio, string tamaño, string urlfoto, List<string> ingredientes)
        {
            if (nombre == "" || precio == 0 || tamaño == "" || urlfoto == "" || ingredientes.Count == 0)
            {
                ViewBag.Error = "No se puede guardar la pizza";
                return View("Error");
            }

            Pizza Pizza = new Pizza(nombre, precio, tamaño, urlfoto);
            
            List<Ingrediente> Ingredientes = new List<Ingrediente>();
            foreach (string ingrediente in ingredientes)
            {
                Ingredientes.Add(Pizzeria.ListarIngredientes().FirstOrDefault(i => i.Nombre == ingrediente));
            }

            Pizza.AgregarIngredientes(Ingredientes);
            
            Pizzeria.AgregarPizza(Pizza);
            return RedirectToAction("Index");
        }
        public IActionResult EliminarPizza(int id)
        {
            Pizzeria.EliminarPizza(id);

            return RedirectToAction("Index");
        }
    }
}