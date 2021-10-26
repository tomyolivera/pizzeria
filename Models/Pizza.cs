using System;
using System.Collections.Generic;

namespace tp09.Models
{
    public class Pizza
    {
        private int _id;
        private string _nombre;
        private double _precio;
        private string _tamaño;
        private string _urlFoto;
        private List <Ingrediente> _ListaIngredientes = new List<Ingrediente>();

        public int Id{ get {return _id;} }
        public string Nombre{ get {return _nombre;} }
        public double Precio{ get {return _precio;} }
        public string Tamaño{ get {return _tamaño;} }
        public string UrlFoto{ get {return _urlFoto;} }
        public List<Ingrediente> ListaIngredientes{ get {return _ListaIngredientes;} }

        public Pizza(string nombre, double precio, string tamaño, string urlFoto)
        {
            Random rnd = new Random();

            _id = rnd.Next(1, 100);
            _nombre = nombre;
            _precio = precio;
            _tamaño = tamaño;
            _urlFoto = urlFoto;
        }

        public List<Ingrediente> ListarIngredientes()
        {
            return _ListaIngredientes;
        }

        public bool AgregarIngredientes(List<Ingrediente> Ingredientes)
        {
            _ListaIngredientes.AddRange(Ingredientes);

            return true;
        }

    }
}
