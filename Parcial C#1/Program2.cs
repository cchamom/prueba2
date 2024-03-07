using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora Básica en C#");

        while (true)
        {
            Console.WriteLine("\nElija una opción:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");

            Console.Write("Opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 5)
            {
                Console.WriteLine("Saliendo de la calculadora.");
                break;
            }

            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                    continue;
            }

            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}


