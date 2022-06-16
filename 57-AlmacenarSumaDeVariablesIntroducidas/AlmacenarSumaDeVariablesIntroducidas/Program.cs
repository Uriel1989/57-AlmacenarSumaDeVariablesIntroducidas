using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlmacenarSumaDeVariablesIntroducidas
{
    class Program
    {
        static void Main(string[] args)
        {
            int Suma = 0;
            Console.CursorLeft = 30;

            Console.WriteLine("Ingresar la cantidad de valores a sumar:");
            int CantidadDeValores = Convert.ToInt32(Console.ReadLine());

            int[] SumaDeValores = new int[CantidadDeValores];

            Console.WriteLine("Ingrese los valores a sumar:");

            for (int i = 0; i<CantidadDeValores; i++)
            {
                SumaDeValores[i] = Convert.ToInt32(Console.ReadLine());

                Suma = SumaDeValores.Sum();
            }

            Console.WriteLine("La suman de los valores da como resultado: " + Suma);

            Console.ReadKey();
        }
    }
}
