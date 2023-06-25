using System;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter 3 sides of triangle:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            if (IsTriangle(a, b, c))
            {
                Console.WriteLine("this is a:");
                TriangleType(a, b, c);
                
              
                Console.WriteLine("triangle.");

            }
            else
            {
                Console.WriteLine("this is not a triangle.");
            }
            Console.ReadKey();
        }
        static bool  IsTriangle(double a,double b,double c)
        {
            if (a + b > c && a + c > b && b + c > a)
                return true;
            else return false;
        }
        static void TriangleType(double a,double b,double c)
        {
            if (a == b && b == c)
                Console.WriteLine("equilateral");
            else if (a == b || a == c)
                Console.WriteLine("isosceles");
            else
                Console.WriteLine("scalene");

        }
        }

    }
   

