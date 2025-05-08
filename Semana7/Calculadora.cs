using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana7
{
    class Calculadora
    {
        private Pila pila = new Pila();

        public void IngresarNumero(double numero)
        {
            pila.Push(numero.ToString());
        }

        public void IngresarOperador(string operador)
        {

            double num2 = double.Parse(pila.Pop());
            double num1 = double.Parse(pila.Pop());
            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                default:
                    throw new ArgumentException("Operador no válido.");
            }

            pila.Push(resultado.ToString());
        }

        public double ObtenerResultado()
        {
            if (pila.Empty())
            {
                throw new InvalidOperationException("La pila está vacía");
            }
            return double.Parse(pila.Peek());
        }

        public string MostrarPila()
        {
            return pila.ToString();
        }
    }
}
