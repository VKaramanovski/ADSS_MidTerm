using System;

namespace ADSS_MidTerm

{
    class Program
    {
        static String smallestWord = "";

        static void shortestWord(String input)
        {

            int lenth = input.Length;
            int a = 0, b = 0;
            int minLength = lenth, minIndex = 0;

            while (b <= lenth)
            {
                if (b < lenth && input[b] != ' ')
                {
                    b++;
                }
                else
                {
                    int currentLength = b - a;

                    if (currentLength < minLength)
                    {
                        minLength = currentLength;
                        minIndex = a;
                    }


                    b++;
                    a = b;
                }
            }

            smallestWord = input.Substring(minIndex, minLength);
        }


        public static void Main(String[] args)
        {

            String a;
            Console.WriteLine("Input a string");
            a = Console.ReadLine();

            shortestWord(a);

            Console.Write("The shortest word is: "
                    + smallestWord)
                   ;
        }
    }
}