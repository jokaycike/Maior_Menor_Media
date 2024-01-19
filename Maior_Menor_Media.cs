using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior_Menor_Media
{
    internal class Maior_Menor_Media
    {
        static void Main(string[] args)
        {
            Denovo();
        }
        public static void Denovo()
        {

            double primeirovalor;
            double segundovalor;
            double terceirovalor;

            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("Digite o primeiro valor:");
            primeirovalor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            segundovalor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceirp valor");
            terceirovalor = double.Parse(Console.ReadLine());

            double Maior = Math.Max(Math.Max(primeirovalor, segundovalor), terceirovalor);

            double Menor = Math.Min(Math.Min(primeirovalor, segundovalor), terceirovalor);

            double Media = (primeirovalor + segundovalor + terceirovalor) / 3;


            Console.WriteLine($"O maior número é: {Maior}");
            Console.WriteLine($"O menor número é: {Menor}");
            Console.WriteLine($"A média dos números é: {Media}");

            Console.ReadLine();
        }
    }
}
