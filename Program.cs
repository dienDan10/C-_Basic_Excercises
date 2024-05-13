using System.Diagnostics.CodeAnalysis;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace C__basic_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ex97("33/33");
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
            if (s.Substring(1, 2).Equals("HP"))
            {
                StringBuilder stringBuilder = new StringBuilder(s);
                stringBuilder.Remove(1, 2);
                Console.WriteLine(stringBuilder.ToString());
            }
        }

        private static void ex40() {
            Console.Write("Input first interger: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input second interger: ");
            int b = int.Parse(Console.ReadLine());
            if (Math.Abs(20 - a) < Math.Abs(20 - b))
            {
                Console.WriteLine(a);
            } else
            {
                Console.WriteLine(b);
            }
        }

        private static void ex41(string s)
        {
            char[] arr = s.ToCharArray();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 'w')
                {
                    count++;
                }
            }

            if (count <= 3 && count >=1)
            {
                Console.WriteLine("true");
            } else
            {
                Console.WriteLine("false");
            }
        }

        private static void ex42()
        {
            Console.WriteLine("Input a string: ");
            string s = Console.ReadLine();

            if (s.Length < 4)
            {
                Console.WriteLine(s.ToUpper());
            } else
            {
                Console.WriteLine(s.Substring(0, 4).ToLower() + s.Substring(4));
            }
        }

        private static void ex44()
        {
            Console.WriteLine("Input a string: ");
            string s = Console.ReadLine();

            char[] arr = s.ToCharArray();
            for (int i = 0;i < arr.Length;i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(arr[i]);
                }
            }
        }

        private static void ex47()
        {
            int[] arr = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int sum = 0;
            for (int i = 0; i < arr.Length;i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum: " + sum);
        }

        private static void ex48()
        {
            int[] arr = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            if (arr[0] == arr[arr.Length - 1]) {
                Console.WriteLine("True");
                return;
            }
            Console.WriteLine("False");
        }

        private static void ex50()
        {
            int[] arr = { 1, 2, 8 };
            Console.WriteLine("Array1: [{0}]", string.Join(", ", arr));
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                int a = arr[left];
                arr[left] = arr[right];
                arr[right] = a;
                left++;
                right--;
            }
            Console.WriteLine("After rotating array becomes: [{0}]", string.Join(", ", arr));
        }

        private static void ex51()
        {
            int[] arr = { 1, 2, 5, 7, 8 };
            Console.WriteLine("Array1: [{0}]", string.Join(", ", arr));
            int max = arr[1];
            for (int i = 0; i < arr.Length; i++) { 
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Highest value between first and last values of the said array: " + max);
        }

        private static void ex52()
        {
            int[] arr1 = { 1, 2, 5 };
            int[] arr2 = { 0, 3, 8 };
            int[] arr3 = { -1, 0, 2};
            int[] arr4 = { arr1[1], arr2[1], arr3[1] };

            Console.WriteLine("Array1: [{0}]", string.Join(", ", arr1));
            Console.WriteLine("Array2: [{0}]", string.Join(", ", arr2));
            Console.WriteLine("Array3: [{0}]", string.Join(", ", arr3));
            Console.WriteLine("New Array: [{0}]", string.Join(", ", arr4));
        }

        private static void ex54(int year)
        {
            if (year < 0)
            {
                Console.WriteLine("Not valid year");
                return;
            }
            int century = year / 100 + 1;
            Console.WriteLine("Century of year {0} is {1}", year, century);
        }

        private static void ex55(int[] arr)
        {
            Console.WriteLine("Array: [{0}]", string.Join(", ", arr));
            if (arr.Length < 2)
            {
                Console.WriteLine("Array length must be greater than 2");
                return;
            }
            int product = arr[0] * arr[1];
            int index = 0;
            for (int i = 0; i < arr.Length - 1; i++) {
                if (arr[i] * arr[i + 1] > product)
                {
                    product = arr[i] * arr[i + 1];
                    index = i;
                }
            }

            Console.WriteLine("Pair of adjacent elements are {0} and {1}", arr[index], arr[index + 1]);
        }

        private static void ex56()
        {
            Console.WriteLine("Input a string: ");
            string s = Console.ReadLine();
            if (string.IsNullOrEmpty(s))
            {
                return;
            }
            char[] arr = s.ToCharArray();
            int left = 0; 
            int right = arr.Length - 1;
            while (left < right)
            {
                if (arr[left] != arr[right])
                {
                    Console.WriteLine("False");
                    return;
                }
                left++;
                right--;
            }
            Console.WriteLine("True");
        }

        private static void ex58(int[] arr, int min, int max)
        {
            int[] count = new int[max - min + 1];
            for (int i = 0; i < count.Length; i++)
            {
                count[i] = 0;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i] - min]++;
            }

            int res = 0;
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] == 0)
                {
                    res++;
                }
            }
            Console.WriteLine(res);
            
        }

        private static void ex61(int[] arr)
        {
            Console.WriteLine("Array: [{0}]", string.Join(", ", arr));
            // create a list to store num ber != -5 in arr
            List<int> list = new List<int>();
            foreach (int i in arr)
            {
                if (i != -5)
                    list.Add(i);
            }
            // sort the list
            list.Sort();
            int count = 0;
            // populate the elements in list to arr
            for (int i = 0; i < arr.Length; i++ )
            {
                if (arr[i] != -5)
                {
                    arr[i] = list[count++];
                }
            }

            Console.WriteLine("After sorted: [{0}]", string.Join(", ", arr));

        }

        private static void ex62(string s)
        {
            // abc(de(fg)cd)dfa
            Console.WriteLine("String: " + s);
            while (s.Contains('('))
            {
                int openParenth = s.LastIndexOf('(');
                int closeParenth = s.IndexOf(')');
                s = s.Substring(0, openParenth)
                    + new string(s.Substring(openParenth + 1, closeParenth - openParenth - 1).Reverse().ToArray())
                    + s.Substring(closeParenth + 1);
            }
            Console.WriteLine("After reverse: " + s);
           
        }

        private static void ex64(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            string fileName = fileInfo.FullName;
            Console.WriteLine("File name: " + fileName.Split('\\').Last());
        }

        private static void ex67(string s)
        {
            string res = s.Replace('P', '9')
                .Replace('T', '0')
                .Replace('S', '1')
                .Replace('H', '6')
                .Replace('A', '8');
            Console.WriteLine("String: " + s);
            Console.WriteLine("After replace: " + res);
        }

        private static void ex70(string s)
        {
            if (s.Length < 3)
            {
                Console.WriteLine("String length must greater than 2");
                return;
            }

            string res = s.Remove(0, 1).Remove(s.Length - 2);
            Console.WriteLine("String: " + s);
            Console.WriteLine("After replace: " + res);
        }

        private static void ex71(string s)
        {
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    Console.WriteLine("False");
                    return;
                }
            }
            Console.WriteLine("True");
        }

        private static void ex72(int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            if (sum % arr.Length == 0)
            {
                Console.WriteLine("True");
            } else
            {
                Console.WriteLine("False");
            }
        }

        private static void ex73(string s)
        {
            Console.WriteLine("Original string: " + s);
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            string res = new string(chars);
            Console.WriteLine("Converted string: " + res);
        }

        private static int ex75(int num)
        {
            return num * 2 - 1;
        }

        private static void ex76(char a)
        {
            Console.WriteLine("ASCII value of {0} is: {1}", a, (int) a);
        }

        private static void ex81(int num)
        {
            Console.WriteLine("Original number: " + num);
            int converted = swap(num);
            Console.WriteLine("Swapped number: " + converted);
            Console.WriteLine("Original value is larger than the swapped value: " + (num > converted));

            int swap(int n)
            {
                int res = 0;
                while (n > 0)
                {
                    res = res * 10 + n % 10;
                    n /= 10;
                }
                return res;
            }
        }

        private static void ex82(string s)
        {
            Console.WriteLine("Original string: " + s);
            Regex regex = new Regex("[^a-zA-Z]");
            string res = regex.Replace(s, "");
            Console.WriteLine("After remove non-letter characters: " + res);
        }

        private static void ex83(string s)
        {
            Console.WriteLine("Original string: " + s);
            Regex regex = new Regex("[ueoaiUEOAI]");
            string res = regex.Replace(s, "");
            Console.WriteLine("After remove all vowels: " + res);
        }

        private static void ex84(string s)
        {
            Console.WriteLine("Original string: " + s);
            char[] arr = s.ToCharArray();
            Console.WriteLine("Indices of all lower case letter: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsLower(arr[i]))
                {
                    Console.Write(i + " ");
                }
            }
        }

        private static void ex85(double[] arr)
        {
            Console.WriteLine("Original array: [{0}]", string.Join(",", arr));
            double sum = 0;
            double[] cumulative = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                cumulative[i] = sum;                
            }
            Console.WriteLine("Cumulative sum: [{0}]", string.Join(",", cumulative));
        }

        private static void ex86(string s)
        {
            Console.WriteLine("Original string: " + s);
            int letterNums = s.Count(char.IsLetter);
            int digitNums = s.Count(char.IsDigit);
            Console.WriteLine("Number of letters: {0}, Number of digits: {1}", letterNums, digitNums);
        }

        private static void ex87(int sides)
        {
            // the formular to calculate the sum of the measure in interior angle is
            // (n - 2) * 180 where n is the number of sides
            Console.WriteLine("Sum of the interior angles of a polygon with {0} sides is {1}", sides, (sides - 2) * 180);
        }

        private static void ex90(int num)
        {
            // convert to binary
            string binary = Convert.ToString(num, 2);
            // count the number of one and zero
            int ones = 0;
            int zeros = 0;
            foreach(char i in binary)
            {
                if (i == '0') zeros++;
                if (i == '1') ones++;
            }

            Console.WriteLine("Number of ones: " +  ones);
            Console.WriteLine("Number of zeros: " + zeros);
        }

        private static void ex91(object[] arr)
        {
            // use Linq OfType method
            Console.WriteLine("Original array: [{0}]", string.Join(", ", arr));
            int[] newArr = arr.OfType<int>().ToArray();
            Console.WriteLine("Original array: [{0}]", string.Join(", ", newArr));
        }

        private static void ex92(int num)
        {
            Console.WriteLine("Original number: " + num);
            if (isPrime(num))
            {
                Console.WriteLine("Next prime number/Current prime number: " + num);
                return;
            }

            for (int i = num + 1; ;i++ )
            {
                if (isPrime(i))
                {
                    Console.WriteLine("Next prime number/Current prime number: " + i);
                    return;
                }
            }


            bool isPrime(int n)
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                        return false;
                }
                return true;
            }
        }

        private static void ex93(int num)
        {
            int left = 0;
            int right = num;
            int middle = num / 2;
            int i = 10;
            while (i > 0)
            {
                if (middle * middle > num)
                {
                    right = middle;                    
                } else
                {
                    left = middle;
                }
                middle = (left + right) / 2;
                i--;
            }

            Console.WriteLine("({0}) -> {1}", num, middle);
        }

        private static void ex94(string[] arr) 
        {
            Array.Sort(arr);
            int count = 0;
            foreach(char c in arr[0])
            {
                bool isEqual = true;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (c != arr[i][count])
                    {
                        isEqual = false;
                    }
                }
                if (isEqual == false)
                {
                    break;
                }
                count++;
            }

            string res = arr[0].Substring(0, count);
            Console.WriteLine("({0}) -> \"{1}\"", string.Join(", ", arr), res);
        }

        private static void ex95(string s)
        {
            char[] arr = s.ToCharArray();
            Stack<char> stack = new Stack<char>();
            bool isValid = true;
            for (int i = 0; i < arr.Length; i++)
            {
                char c = arr[i];
                if (c == '(')
                {
                    stack.Push(')');
                } else if (c == '[')
                {
                    stack.Push(']');
                } else if (c == '{')
                {
                    stack.Push('}');
                } else if (c == '<')
                {
                    stack.Push('>');
                }
                else
                {
                    // when stack is empty or the closing char is different
                     if (stack.Count == 0 || stack.Pop() != c)
                    {
                        isValid = false;
                    }
                }
            }
            // when stack still contains elements
            if (stack.Count > 0)
            {
                isValid = false;
            }
            Console.WriteLine("(\"{0}\") -> {1}", s, isValid);
        }

        private static void ex97(string s)
        {
            bool res = double.TryParse(s, out _ );
            Console.WriteLine("(\"{0}\") -> {1}", s, res);
        }

    }
}
