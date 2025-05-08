using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana7
{
    class nodo
    {
        public string Dato { get; set; }
        public nodo Sig { get; set; }

        public nodo(string dato)
        {
            Dato = dato;
            Sig = null;
        }

        public nodo()
        {
            Sig = null;
        }
    }
}
