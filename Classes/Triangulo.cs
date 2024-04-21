using System.Globalization;
namespace CalcMediaCs.Classes
{
    public class Triangulo
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        public Triangulo() { }
        public Triangulo(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        public void ImprimeArea()
        {
            Console.WriteLine("Area do triangulo = " + Area().ToString("F4", CultureInfo.InvariantCulture));
        }
        public void CapturaCoordenadas()
        {
            double a, b, c;
            Console.WriteLine("Entre com as medidas do triângulo :");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A = a;
            B = b;
            C = c;
        }
    }
}

