using System;

namespace ejercicios2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresar Primer Número");
            int primerNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar Segundo Número");
            int segundoNumero = int.Parse(Console.ReadLine());

            if(primerNumero < segundoNumero)
            {
            Console.WriteLine("Primer número ingresado es menor que el segundo");

            }
            else if (primerNumero > segundoNumero)
            {
                Console.WriteLine("Primer número ingresado es mayor que el segundo");

            }
            else
            {
                Console.WriteLine("Ambos números son iguales");

            }
        }
    }
}
