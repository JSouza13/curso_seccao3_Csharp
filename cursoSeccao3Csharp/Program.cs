using System;
using System.Globalization;

namespace cursoSeccao3Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo X, Y;
            double areaX, areaY;

            X = new Triangulo();
            Y = new Triangulo();

            X.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.a= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Y.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            areaX = X.Area();
            areaY = Y.Area();

            Console.WriteLine("AREA DO TRINGULO X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("AREA DO TRINGULO Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX >areaY)
            {
                Console.WriteLine("TRIANGULO DE MAIOR  AREA: X");
            }
            else if (areaY > areaX)
            {
                Console.WriteLine("TRIANGULO DE MAIOR AREA: Y");
            }
            else
            {
                Console.WriteLine("AREAS IGUAIS");
            }
            Console.ReadLine();
        }
    }
}
