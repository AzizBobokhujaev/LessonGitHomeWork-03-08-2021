using System;

namespace GitConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------------HomeWork_1---------------");
            double a ,b;
            Console.Write("a=");a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");b = Convert.ToDouble(Console.ReadLine());
            double result_1 = Math.Sqrt(a*b);
            Console.WriteLine("Result:"+result_1);

            Console.WriteLine("---------------HomeWork_2---------------");
            double A,B,C,AC,BC, sum;
            Console.Write("A=");A = Convert.ToDouble(Console.ReadLine());
            Console.Write("B=");B = Convert.ToDouble(Console.ReadLine());
            Console.Write("C=");C = Convert.ToDouble(Console.ReadLine());
            AC = Math.Abs(A-C);
            BC = Math.Abs(B-C);
            sum = AC+BC;
            Console.WriteLine("AC="+AC);
            Console.WriteLine("BC="+BC);
            Console.WriteLine("sum="+sum);

            Console.WriteLine("---------------HomeWork_3---------------");
            double x1,y1,x2,y2;
            Console.Write("x1=");x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1=");y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2=");x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2=");y2 = Convert.ToDouble(Console.ReadLine());
            double length = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
            Console.WriteLine("Line length ="+length);

            Console.WriteLine("---------------HomeWork_4---------------");
            int number, firstDivision ,secondDivision, reverse;
            Console.Write("Number = ");number = Convert.ToInt32(Console.ReadLine());
            firstDivision = number / 10;
            secondDivision = number % 10;
            reverse = secondDivision * 10 + firstDivision;
            Console.WriteLine("Reverse Number = "+reverse);

            Console.WriteLine("---------------HomeWork_5---------------");
            int n, result;
            Console.Write("Seconds = ");n = Convert.ToInt32(Console.ReadLine());
            result = n / 60;
            Console.WriteLine($"Minutes = {result}");
        }
        
    }
}
