using System;

namespace PracSem2Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de variables 
            string firstname = "Enrique";
            String lastname = "Marenco";
            int edad = 27;
            //Concatenacion de variables 
            var name = firstname + " " + lastname;
            //Imprimir variables dentro del texto 
            Console.WriteLine("Su nombre es: {0} y su edad es: {1}", name, edad);
        }
    }
}
