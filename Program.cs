using System;

namespace primerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            double resultado;


            Console.WriteLine("Favor Introducir el Primer Número.");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Favor Introducir el Segundo Número.");
            numero2 = Convert.ToInt32(Console.ReadLine());
            //suma
            resultado = numero1 + numero2;
            Console.WriteLine("El resultado de la suma de " + numero1 + " y " + numero2 + " es: = " + resultado);
            //resta
            resultado = numero1 - numero2;
            Console.WriteLine("El resultado de la resta de " + numero1 + " y " + numero2 + " es: = " + resultado);
            //multiplicación
            resultado = numero1 * numero2;
            Console.WriteLine("El producto de " + numero1 + " y " + numero2 + " es: = " + resultado);
            // divicion
            resultado = numero1 / numero2;
            Console.WriteLine("El cociente de " + numero1 + " y " + numero2 + " es: = " + resultado);

            Console.ReadKey();

        }
    }
}
