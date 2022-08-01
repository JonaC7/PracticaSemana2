using System;

namespace ejercico4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Introdusca un numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("introdusca su edad");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma de los numeros es: {0}", + (num1 + num2));
            Console.WriteLine("La resta de los numeros es: {0}", +(num1 - num2));
        }
    }
}
