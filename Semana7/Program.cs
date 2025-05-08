using Semana7;

Calculadora calc = new Calculadora();

Console.WriteLine("*************** Calculadora ***************");
Console.WriteLine("Ingrese números u operadores.");
Console.WriteLine("Ingrese 'salir' para salir del programa");

while (true)
{
    Console.WriteLine("\nPila actual:");
    Console.WriteLine(calc.MostrarPila());

    Console.Write("Entrada: ");
    string entrada = Console.ReadLine();

    if (entrada.ToLower() == "salir") break;

        if (double.TryParse(entrada, out double numero))
        {
            calc.IngresarNumero(numero);
        }
        else if (entrada == "+" || entrada=="-" || entrada == "*" || entrada == "/")
        {
            calc.IngresarOperador(entrada);
            Console.WriteLine($"Resultado: {calc.ObtenerResultado()}");
        }
        else
        {
            Console.WriteLine("\nEntrada no válida.");
        }
    }
