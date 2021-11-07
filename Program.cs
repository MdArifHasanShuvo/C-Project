using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_1264713
{
    class Program
    {
        static DateTime Exam;



        static void Main(string[] args)
        {
            UsingVariables();
            Console.WriteLine();
            prepostfix();
            Console.WriteLine();
            UsingDicision();
            Console.WriteLine("ans to the question no 6-a");
            UsingLoops();
            Console.WriteLine();
            foreach (char c in "MANIK")
            {
                Console.WriteLine($"{c}-");
            }

            Console.ReadKey();

            OptinanlParameterMethod("Message string", 3);
            OptinanlParameterMethod("Message string");
            Console.WriteLine();

        }//Main
        static void UsingVariables()
        {
            Console.WriteLine("Global Variable");
            Exam = new DateTime(2021, 06, 27);
            Console.WriteLine($"Exam date:{Exam:yyyy-mm-dd}");
            Console.WriteLine("Local Variable");
            string course = "OL-WADA";
            float pi = 3.14F;
            decimal wage = 9999.223M;
            Console.WriteLine($"course:{course}");
            Console.WriteLine($"pi={pi}");
            Console.WriteLine($"wage={wage}");
        }
        static void prepostfix()
        {
            Console.WriteLine("pre and post fix");
            int x = 10;
            Console.WriteLine($"x={x}");
            int m = ++x;
            Console.WriteLine($"m={m}");
            Console.WriteLine($"x={x}");
            int n = x++;
            Console.WriteLine($"n={n}");
            Console.WriteLine($"x={x}");
        }
        static void UsingDicision()
        {
            
            Console.WriteLine("if......else..");
            Random r = new Random();
            int n1 = r.Next(1, 10);
            int n2 = r.Next(1, 10);
            Console.WriteLine($"{n1}+{n2}=?");
            int ans = int.Parse(Console.ReadLine());
            if (ans == n1 + n2)
            {
                Console.WriteLine("It's True");
            }
            else
            {
                Console.WriteLine("It's false");
            }
            Console.WriteLine("switch case");
            switch (ans == n1 + n2)
            {
                case true:
                    Console.WriteLine("It's true");
                    break;
                case false:
                    Console.WriteLine("It's false");
                    break;

                default:
                    Console.WriteLine("Result Error");
                    break;
            }

        }
        static void UsingLoops()
        {
            Console.WriteLine("for loop");
            long sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}\t");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Series Sum = {sum}");
            Console.WriteLine("while loop");
            sum = 0;
            int j = 10;
            while (j > 0)
            {
                Console.Write($"{j}\t");
                sum += j;
                j--;
            }
            Console.WriteLine();
            Console.WriteLine($"Series Sum = {sum}");
            Console.WriteLine();
            Console.WriteLine("do while loop");
            int k = 0;
            do
            {

                k++;
                Console.Write($"{k}\t");
            } while (k < 10);
            Console.WriteLine();

        }

        static void VoidMethod(string v)
        {
            var old = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(v);
            Console.ForegroundColor = old;
        }

        static void MultiParameterMethod(string msg, int n)
        {
            var old = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(msg);
            }

            Console.ForegroundColor = old;
        }

        static double ValueReturnMethod(double n, double d)
        {
            return n / d;
        }

        static void OptinanlParameterMethod(string msg, int n = 1)
        {
            var old = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;//
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(msg);
            }

            Console.ForegroundColor = old;
            Console.ReadKey();
        }
        
    }//class
}//namespace
