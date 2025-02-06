using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace POAgenda
{
    internal class Contacto
    {
        //estos son campos
        private string _nombre;
        private string _telefono;

        //estos son permisos para que se puedan ver desde fuera "propiedad"
        public string Nombre {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        public string Telefono { 
            get
            { 
                return _telefono;
            }
            set
            {
                _telefono = value;
            }
        }
        // los campos _nombre y _telefono obtienen la infomacion de los campos y lo que se reciva lo reciben el _nombre y _telefono
        //esto es un constructor 
        public Contacto(string nombre, string telefono) 
        {
            _nombre = nombre;
            _telefono = telefono;
        }
    }
}
