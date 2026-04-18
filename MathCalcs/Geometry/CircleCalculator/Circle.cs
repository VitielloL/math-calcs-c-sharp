using MathCalcs.Geometry.CircleCalculator;
using System;
using System.Globalization;

namespace MathCalcs.Geometry.CircleCalculator
{
    public static class Circle
    {
        public static void AreaDoCirculo()
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculator.Circunferencia(raio);
            double volume = Calculator.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculator.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
