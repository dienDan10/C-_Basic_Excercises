using System.Reflection.PortableExecutable;
using System.Text;

namespace C__basic_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ex37();
        }

        private static void ex1()
        {
            Console.WriteLine("Hello, Tran Dinh Tu");
        }

        private static void ex2()
        {
            Console.WriteLine($"the sum of {5} and {10} is {5 + 10}");
        }

        private static void ex3()
        {
            Console.WriteLine($"The result of {20}/{7} is {20 / 7}");
        }

        private static void ex4()
        {
            Console.WriteLine((-1 + 4 * 6));
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine((14 + -4 * 6 / 11));
            Console.WriteLine((2 + 15 / 6 * 1 - 7 % 2));
        }

        private static void ex5()
        {
            Console.Write("Input the First Number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input the Second Number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("After Swapping:");
            Console.WriteLine("First Number: " + b);
            Console.WriteLine("Second Number: " + a);
        }

        private static void ex6()
        {
            Console.Write("Input the first number to multiply: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input the second number to multiply: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Input the third number to multiply: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} x {b} x {c} = {a * b * c}");
        }

        private static void ex7()
        {
            Console.Write("Input the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} x {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} mod {b} = {a % b}");
        }

        private static void ex8()
        {
            Console.Write("Enter the number: ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10 ; i++)
            {
                Console.WriteLine($"{a} * {i} = {a * i}");
            }
        }

        private static void ex9()
        {
            Console.Write("Input the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Input the third number: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Input the fourth number: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine($"The average of {a}, {b}, {c}, {d} is: {(a+b+c+d)/4}");
        }

        private static void ex13()
        {
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            for ( int i = 0; i < 5; i++)
            {
               for (int j = 0; j < 3; j++)
                {
                    if (i > 0 && i < 4 && j == 1 )
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(a);
                    }
                }
                Console.WriteLine();
            }
        }

        private static void ex15()
        {
            string s = "w3resource";
            Console.WriteLine("{0}", s.Remove(1,1));
            Console.WriteLine("{0}", s.Remove(s.Length - 1));
        }

        private static void ex16()
        {
            string s1 = "w3resource";
            string s2 = "Python";

            operation(s1);
            operation(s2);

            void operation(string s)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(s.Substring(s.Length - 1));
                stringBuilder.Append(s.Substring(1, s.Length - 2));
                stringBuilder.Append(s.Substring(0,1));
                Console.WriteLine(stringBuilder.ToString());
            }

        }

        private static int ex20(int a, int b)
        {
            if (a > b)
            {
                return Math.Abs(a - b) * 2;
            }
            return Math.Abs(a - b);
        }

        private static void ex24()
        {
            string s = "Write a C# Program to display the following pattern using the alphabet";
            string[] arr = s.Split(' ');
            int maxIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[maxIndex].Length < arr[i].Length)
                {
                    maxIndex = i;
                }
            }
            Console.WriteLine(arr[maxIndex]);
        }

        private static void ex27()
        {
            Console.Write("Input a number(Integer): ");
            int input = int.Parse(Console.ReadLine());

            int sum(int a)
            {
                int b = 0;
                while (a > 0)
                {
                    b += a % 10;
                    a /= 10;
                }

                return b;
            }

            Console.WriteLine("Sum of the digits of the said Integer: " + sum(input));

        }

        private static void ex28()
        {
            string s = "Display the pattern like pyramid using the alphabet.";
            string[] arr = s.Split(" ");
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = arr.Length - 1; i >=0 ; i--)
            {
                stringBuilder.Append(arr[i]);
            }
            Console.WriteLine(stringBuilder.ToString());

        }

        private static void ex37()
        {
            string s = "PHP Tutorial";
            if (s.Substring(1).Contains("HP"))
            {
                StringBuilder stringBuilder = new StringBuilder(s);
                stringBuilder.Remove(1, 2);
                Console.WriteLine(stringBuilder.ToString());
            }
        }



    }
}
