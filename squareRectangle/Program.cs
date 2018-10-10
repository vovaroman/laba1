using System;

namespace squareRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c ,x1, x2, d;
            Console.WriteLine("Введите значения a b c через пробел: \n Ex:1 2 3");
            string variables = Console.ReadLine();
            string[] data = variables.Split(' ');
            a = double.Parse(data[0]);
            b = double.Parse(data[1]);
            c = double.Parse(data[2]);
            d = b * b - 4 * a * c;
            if (d > 0)
            {
                x1 = (-b - Math.Sqrt(d)) / 2;
                x2 = (-b + Math.Sqrt(d)) / 2;
                Console.WriteLine(string.Format(" x1 = {0} \n" +
                                            " x2 = {1} \n " +
                                            " d = {2} ", x1, x2, d));
            }
            else if ((int)d == 0)
            {
                x1 = (-b / 2 * a);
                Console.WriteLine(string.Format(" x = {0} \n" +
                                            " d = {1} ", x1, d));
            }
            else{
                Console.Write(" d < 0... sorry...");
            }

            Console.ReadLine();


        }
    }
}
