using System;

namespace comparando2
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero;
            int segundoNumero;
            int tercerNumero;
            double resultado;

            Console.WriteLine("Ingresar Primer Número");
             primerNumero = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar Segundo Número");
             segundoNumero = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar Tercer Número");
             tercerNumero = Int32.Parse(Console.ReadLine());

            

            if (primerNumero < segundoNumero  && segundoNumero < tercerNumero)
            {
                Console.WriteLine("Primer número ingresado es el menor, segundo número es intermedio y el tercero es el mayor");
                resultado = tercerNumero + primerNumero;
                Console.WriteLine(" La suma del mayor y el menor es: " + resultado);
                resultado = primerNumero + segundoNumero;
                Console.WriteLine(" La suma del menor y el intermedio es: " + resultado);
                resultado = tercerNumero * segundoNumero;
                Console.WriteLine(" El producto del mayor y el intermedio es: " + resultado);

            }
            else if (primerNumero > segundoNumero && segundoNumero > tercerNumero)
            {
                Console.WriteLine("Primer número ingresado es el mayor, segundo número es el intermedio y el tercero es el menor");
                resultado = primerNumero + tercerNumero;
                Console.WriteLine(" La suma del mayor y el menor es: " + resultado);
                resultado = tercerNumero + segundoNumero;
                Console.WriteLine(" La suma del menor y el intermedio es: " + resultado);
                resultado = primerNumero * segundoNumero;
                Console.WriteLine(" El producto del mayor y el intermedio es: " + resultado);

            }

            else if (segundoNumero > primerNumero && primerNumero > tercerNumero)
            {
                Console.WriteLine("Segundo número ingresado es el mayor, primer número es el intermedio y el tercero es el menor");
                resultado = segundoNumero + tercerNumero;
                Console.WriteLine(" La suma del mayor y el menor es: " + resultado);
                resultado = tercerNumero + primerNumero;
                Console.WriteLine(" La suma del menor y el intermedio es: " + resultado);
                resultado = primerNumero * segundoNumero;
                Console.WriteLine(" El producto del mayor y el intermedio es: " + resultado);
            }

            else if (tercerNumero > primerNumero && primerNumero > segundoNumero)
            {
                Console.WriteLine("Tercer número ingresado es el mayor, primer número es el intermedio y el segundo es el menor");
                resultado = tercerNumero + segundoNumero;
                Console.WriteLine(" La suma del mayor y el menor es: " + resultado);
                resultado =  segundoNumero + primerNumero;
                Console.WriteLine(" La suma del menor y el intermedio es: " + resultado);
                resultado = primerNumero * tercerNumero;
                Console.WriteLine(" El producto del mayor y el intermedio es: " + resultado);
            }

            else if (segundoNumero < tercerNumero && tercerNumero < primerNumero)
            {
                Console.WriteLine("Segundo número ingresado es el mayor, tercer número es el intermedio y el primero es el menor");
                resultado = segundoNumero + primerNumero;
                Console.WriteLine(" La suma del mayor y el menor es: " + resultado);
                resultado = tercerNumero + primerNumero;
                Console.WriteLine(" La suma del menor y el intermedio es: " + resultado);
                resultado = tercerNumero * segundoNumero;
                Console.WriteLine(" El producto del mayor y el intermedio es: " + resultado);
            }

            else if (primerNumero < tercerNumero && tercerNumero < segundoNumero)
            {
                Console.WriteLine("Primer número ingresado es el mayor, tercer número es el intermedio y el segundo es el menor");
                resultado = primerNumero + segundoNumero;
                Console.WriteLine(" La suma del mayor y el menor es: " + resultado);
                resultado = tercerNumero + segundoNumero;
                Console.WriteLine(" La suma del menor y el intermedio es: " + resultado);
                resultado = primerNumero * tercerNumero;
                Console.WriteLine(" El producto del mayor y el intermedio es: " + resultado);
            }

            else
            {
                Console.WriteLine("No se cumplen los parámatros");

            }
        }
    }
}
