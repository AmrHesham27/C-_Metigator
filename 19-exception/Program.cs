using System;

namespace _19_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Amr.Calculate(2, 0);
        }

        // Exception is the super class for all excptions

        // you can see exception during the trouplshooting

        // just add breaking point and hover on the excpetion keyword and you will see it

        // if you do not have try catch you will get message with the exact exception
        // DivideByZeroException, there is difference from Exception and its message

        class Amr 
        {
            public static void Calculate(int x, int y)
            {
                try
                {
                   Console.WriteLine(x / y);
                }
                catch (Exception excpetion) when (excpetion.Source == "19-exception")
                {
                    Console.WriteLine(excpetion);
                    Console.WriteLine("excption detected!!");
                }
                finally
                {
                    Console.WriteLine("done");
                }
                
            }

            // you can also  add case for catching exception
        }
    }
}