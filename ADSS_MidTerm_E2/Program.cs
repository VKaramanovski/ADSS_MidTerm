using System;

namespace ADSS_MidTerm_E2

{
    class Program
    {
        static void Main(string[] args)
        {
            int rows;
            int count = 1;
            int value;

            Console.WriteLine("Please enter the number of rows to generate a binary Triangle");
            rows = Int32.Parse(Console.ReadLine());

            for (int lines = rows; lines >= 1; lines--)
            {


                for (int numInRow = 1; numInRow <= count; numInRow++)
                {
                    value = numInRow % 2;
                    Console.Write(value);
                }
                count++;

                Console.WriteLine();
            }
        }
    }
}
