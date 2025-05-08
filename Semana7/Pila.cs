using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana7
{
    class Pila
    {
        private nodo Primero { get; set; }

        public void Push(string valor)
        {
            nodo nuevo = new nodo(valor)
            {
                Sig = Primero
            };
            Primero = nuevo;
        }

        public string Pop()
        {
            if (Primero == null)
            {
                throw new InvalidOperationException("La pila está vacía");
            }
            string valor = Primero.Dato;
            Primero = Primero.Sig;
            return valor;
        }

        public string Peek()
        {
            if (Primero == null)
            {
                throw new InvalidOperationException("La pila está vacía");
            }
            return Primero.Dato;
        }

        public bool Empty()
        {
            return Primero == null;
        }

        public int Size()
        {
            int contador = 0;
            nodo actual = Primero;
            while (actual != null)
            {
                contador++;
                actual = actual.Sig;
            }
            return contador;
        }

        public override string ToString()
        {
            string resultado = "";
            nodo actual = Primero;
            while (actual != null)
            {
                resultado = actual.Dato + "\n" + resultado;
                actual = actual.Sig;
            }
            return resultado;
        }
    }
}
