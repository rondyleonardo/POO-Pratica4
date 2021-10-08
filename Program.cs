using System;
using System.Globalization;

namespace Exercício1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo medida = new Retangulo();

            Console.WriteLine("Entre a LARGURA e a altura do retângulo: ");
            medida.Largura = double.Parse(System.Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre a ALTURA e a altura do retângulo: ");
            medida.Altura = double.Parse(System.Console.ReadLine(),CultureInfo.InvariantCulture);

            System.Console.WriteLine("AREA = "+medida.Area().ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("PERÍMETRO = "+medida.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("DIAGONAL = "+medida.Diagonal().ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
