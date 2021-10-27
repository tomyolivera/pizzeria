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

            if(ViewBag.Pizza == null){
                ViewBag.Error = "Pizza no encontrada!";
                return RedirectToAction("Index");
            }

            return View("DetallePizza");
        }

        public IActionResult AgregarPizza()
        {
            ViewBag.Ingredientes = Pizzeria.ListarIngredientes();
            ViewBag.Pizza = new List<Pizza>();
            ViewBag.editing = false;
            return View("FormularioPizza");
        }

        [HttpPost]
        public IActionResult GuardarPizza(string nombre, double precio, string Tamano, string urlfoto, List<string> ingredientes)
        {
            if (nombre == "" || precio == 0 || Tamano == "" || urlfoto == "" || ingredientes.Count == 0)
            {
                ViewBag.Error = "No se puede guardar la pizza: Faltan completar campos";
                return RedirectToAction("Index");
            }

            Random rnd = new Random();
            int id = rnd.Next(1, 100);            
            bool found = true;
            
            while (found)
            {
                id = rnd.Next(1, 100);
                if(Pizzeria.ListarPizzas().FirstOrDefault(p => p.Id == id) == null)
                    found = false;
            }
            
            Pizza Pizza = new Pizza(id, nombre, precio, Tamano, urlfoto);
            
            List<Ingrediente> Ingredientes = new List<Ingrediente>();
            foreach (string ingrediente in ingredientes)
            {
                Ingredientes.Add(Pizzeria.ListarIngredientes().FirstOrDefault(i => i.Nombre == ingrediente));
            }

            Pizza.AgregarIngredientes(Ingredientes);
            
            Pizzeria.AgregarPizza(Pizza);
            return RedirectToAction("Index");
        }

        public IActionResult EditarPizza(int id)
        {
            ViewBag.Pizza = Pizzeria.ListarPizzas().FirstOrDefault(p => p.Id == id);

            if(ViewBag.Pizza == null){
                ViewBag.Error = "Pizza no encontrada!";
                return RedirectToAction("Index");
            }

            ViewBag.Ingredientes = Pizzeria.ListarIngredientes();
            ViewBag.editing = true;
            return View("FormularioPizza");
        }

        [HttpPost]
        public IActionResult ActualizarPizza(int id, string nombre, double precio, string Tamano, string urlfoto, List<string> ingredientes)
        {
            if (nombre == "" || precio == 0 || Tamano == "" || urlfoto == "" || ingredientes.Count == 0)
            {
                ViewBag.Error = "No se puede guardar la pizza: Faltan completar campos";
                return RedirectToAction("Index");
            }

            Pizza Pizza = Pizzeria.ListarPizzas().FirstOrDefault(p => p.Id == id);
            Pizza.Nombre = nombre;
            Pizza.Precio = precio;
            Pizza.Tamano = Tamano;
            Pizza.UrlFoto = urlfoto;

            List<Ingrediente> Ingredientes = new List<Ingrediente>();
            foreach (string ingrediente in ingredientes)
            {
                Ingredientes.Add(Pizzeria.ListarIngredientes().FirstOrDefault(i => i.Nombre == ingrediente));
            }

            Pizza.AgregarIngredientes(Ingredientes);
            return RedirectToAction("Index");
        }


        public IActionResult EliminarPizza(int id)
        {
            if(!Pizzeria.EliminarPizza(id))
                ViewBag.Error = "No se puede eliminar la pizza";
            
            return RedirectToAction("Index");
        }
    }
}