using System;

namespace ADSS_MidTerm_E4
{
    class Program
    { 
        static void Main(string[] args)

        {
            int a, b, c;

            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            c = Int32.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(a, b, c);

            isRight(triangle);
            
        }

        public static void isRight(Triangle triangle)


        {
            float a, b, c;
            a = Math.Pow(triangle.a, 2);
            b = Math.Pow(triangle.b, 2);
            c = Math.Pow(triangle.c, 2);

            if ( c == a + b)
            {
                Console.WriteLine("The triangle is Right");
                Console.WriteLine("Perimetar:{0} ", triangle.a + triangle.b + triangle.c);
            }

            else
            {
                Console.WriteLine("ERROR");
            }


        }
    }
    
}
