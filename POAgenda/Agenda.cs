using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POAgenda
{
    internal class Agenda
    {
        private Contacto[] _contactos;
        private int _tope;

        public Agenda()
        {
            _contactos = new Contacto[50];
            _tope = 0;
        }
        //metodo es void
        public void Agregar(Contacto contacto)
        {
            _contactos[_tope] = contacto;
            _tope++;
        }
        //_contactos es mi arreglo, tenemos dos metodos uno para agregar y otro para regresarlos y imprimirlos.
        public Contacto[] ObtenerContactos()
        {
            return _contactos;  
        }
    }
}
