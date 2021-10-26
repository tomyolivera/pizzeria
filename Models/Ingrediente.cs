using System;

namespace tp09.Models
{
    public class Ingrediente
    {
        private int _id;
        private string _nombre;
        private string _urlFoto;

        public int Id{ get {return _id;} }
        public string Nombre{ get {return _nombre;} }
        public string UrlFoto{ get {return _urlFoto;} }

        public Ingrediente(string nombre, string urlFoto)
        {
            Random rnd = new Random();

            _id = rnd.Next(1, 100);
            _nombre = nombre;
            _urlFoto = urlFoto;
        }
    }
}