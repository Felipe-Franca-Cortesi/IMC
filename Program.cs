using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Índice de massa corporal");

            Console.Write("Altura (m)..: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Peso (kg)...:");
            double peso = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine($"IMC: {imc} kg/m²");
        }
    }
}
