using System;
using System.Collections.Generic;

namespace tp09.Models
{
    public class Pizza
    {
        private int _id;
        private string _nombre;
        private double _precio;
        private string _Tamano;
        private string _urlFoto;
        private List <Ingrediente> _ListaIngredientes = new List<Ingrediente>();

        public int Id{ get {return _id;} set { _id = value; } }
        public string Nombre{ get {return _nombre;} set { _nombre = value; } }
        public double Precio{ get {return _precio;} set { _precio = value; } }
        public string Tamano{ get {return _Tamano;} set { _Tamano = value; } }
        public string UrlFoto{ get {return _urlFoto;} set { _urlFoto = value; } }
        public List<Ingrediente> ListaIngredientes{ get {return _ListaIngredientes;} }

        public Pizza(int id, string nombre, double precio, string Tamano, string urlFoto)
        {
            _id = id;
            _nombre = nombre;
            _precio = precio;
            _Tamano = Tamano;
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
