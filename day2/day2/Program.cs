using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region _1
            Console.WriteLine("compute the sum of the two given integer values.If the two values are the same, then return triple their sum.");
            int f1 = 1;

            do
            {
                Console.WriteLine("enter your first number");
                bool isFirstValid = int.TryParse(Console.ReadLine(), out int n1);

                Console.WriteLine("enter your second number");
                bool isSecondValid = int.TryParse(Console.ReadLine(), out int n2);

                if (isFirstValid && isSecondValid)
                {
                    if (n1 == n2)
                        Console.WriteLine($"triple sum = {(n1 + n2) * 3}");
                    else
                        Console.WriteLine($"sum = {(n1 + n2)}");

                    Console.WriteLine("enter 0 to end or 1 to complete");
                    f1 = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter numbers only.");
                }

            }
            while (f1 == 1);
            Console.WriteLine();
            #endregion

            #region _2
            int f2;
            do
            {
                f2 = 1;
                Console.WriteLine("enter your integer to get the absolute difference between n and 51 ");
                bool isNumberValid = int.TryParse(Console.ReadLine(), out int n);
                if (isNumberValid)
                {
                    if (n < 51)
                    {
                        Console.WriteLine($"difference from 51 = {51 - n}");
                        Console.WriteLine("enter 0 to exit and 1 to continue");
                        f2 = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine($"abs triple differnce from 51 = {(Math.Abs(51 - n)) * 3}");
                        Console.WriteLine("enter 0 to exit and 1 to continue");
                        f2 = int.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    Console.WriteLine("enter valid number");
                }

            } while (f2 == 1);
            Console.WriteLine();

            #endregion

            #region _3
            Console.WriteLine("check two given integers, and return true if one of them is 30 or if their sum is 30.");
            int f3;
            do
            {
                f3 = 1;
                Console.WriteLine("enter your first integer");
                bool isSecondNumberValid = int.TryParse(Console.ReadLine(), out int n1);
                Console.WriteLine("enter your second integer");
                bool isFirstNumberValid = int.TryParse(Console.ReadLine(), out int n2);
                if (isFirstNumberValid && isSecondNumberValid)
                {
                    if (n1 == 30 || n2 == 30 || (n1 + n2 == 30))
                    {
                        Console.WriteLine("true");
                        Console.WriteLine("enter 0 to exit and 1 to continue");
                        f3 = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("false");
                        Console.WriteLine("enter 0 to exit and 1 to continue");
                        f3 = int.Parse(Console.ReadLine());
                    }

                }
                else
                {
                    Console.WriteLine("enter valid number");
                }

            } while (f2 == 1);
            Console.WriteLine();
            #endregion

            #region _4
            int f4;
            do
            {
                f4 = 1;
                Console.WriteLine("enter your integer to check if it is a multiple of 3 or a multiple of 7");
                bool isNumberValid = int.TryParse(Console.ReadLine(), out int n);
                if (isNumberValid)
                {
                    if (n % 3 == 0 && n % 7 == 0)
                    {
                        Console.WriteLine("true");
                        Console.WriteLine("enter 0 to exit and 1 to continue");
                        f4 = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("false");
                        Console.WriteLine("enter 0 to exit and 1 to continue");
                        f4 = int.Parse(Console.ReadLine());
                    }

                }
                else
                {
                    Console.WriteLine("enter valid number");
                }

            } while (f4 == 1);
            Console.WriteLine();
            #endregion

            #region _5
            Console.WriteLine("check two given integers whether either of them \r\nis in the range 100..200 inclusive.");
            int f5;
            do
            {
                f5 = 1;
                Console.WriteLine("enter your first integer");
                bool isFiretNumberValid = int.TryParse(Console.ReadLine(), out int n1);
                Console.WriteLine("enter your second integer");
                bool isSecondNumberValid = int.TryParse(Console.ReadLine(), out int n2);
                if (isFiretNumberValid && isSecondNumberValid)
                {
                    if ((n1 >= 100 & n1 <= 200) || (n2 >= 100 & n2 <= 200))
                    {
                        Console.WriteLine("true");
                        Console.WriteLine("enter 0 to exit and 1 to continue");
                        f5 = int.Parse(Console.ReadLine());

                    }
                    else
                    {
                        Console.WriteLine("false");
                        Console.WriteLine("enter 0 to exit and 1 to continue");
                        f5 = int.Parse(Console.ReadLine());
                    }

                }
                else
                {
                    Console.WriteLine("enter valid number");
                }

            } while (f5 == 1);
            Console.WriteLine();
            #endregion

            #region _6
            Console.WriteLine("check whether three given integer values are in \r\nthe range 20..50 inclusive. Return true if 1 or more of them are in the said range otherwise false.");
            int f6;
            do
            {
                f6 = 1;
                Console.WriteLine("enter your first integer");
                bool isFirstNumberValid = int.TryParse(Console.ReadLine(), out int n1);
                Console.WriteLine("enter your second integer");
                bool isSecondNumberValid = int.TryParse(Console.ReadLine(), out int n2);
                Console.WriteLine("enter your third integer");
                bool isThirdNumberValid = int.TryParse(Console.ReadLine(), out int n3);
                if (isFirstNumberValid && isSecondNumberValid && isThirdNumberValid)
                {
                    if ((n1 >= 20 && n1 <= 50) || (n2 >= 20 && n2 <= 50) || (n3 >= 20 && n3 <= 50))
                    {
                        Console.WriteLine("true");
                        Console.WriteLine("enter 0 to exit and 1 to continue");
                        f5 = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("false");
                        Console.WriteLine("enter 0 to exit and 1 to continue");
                        f6 = int.Parse(Console.ReadLine());
                    }

                }
                else
                {
                    Console.WriteLine("enter valid number");
                }

            } while (f6 == 1);
            Console.WriteLine();
            #endregion

            #region _7
            Console.WriteLine("7- check the largest number among three given \r\nintegers.\r\n");
            int f7;
            do
            {
                f7 = 1;
                Console.WriteLine("enter your first integer");
                bool isFirstNumberValid = int.TryParse(Console.ReadLine(), out int n1);
                Console.WriteLine("enter your second integer");
                bool isSecondNumberValid = int.TryParse(Console.ReadLine(), out int n2);
                Console.WriteLine("enter your third integer");
                bool isThirdNumberValid = int.TryParse(Console.ReadLine(), out int n3);
                if (isFirstNumberValid && isSecondNumberValid && isThirdNumberValid)
                {
                    int max;
                    if (n1 > n2 && n1 > n3)
                    {
                        max = n1;
                    }
                    else if (n2 > n1 && n2 > n3)
                    {
                        max = n2;
                    }
                    else { max = n3; }
                    Console.WriteLine($"maximum numbe = {max}");
                    Console.WriteLine("enter 0 to exit and 1 to continue");
                    f7 = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("enter valid number");
                }

            } while (f7 == 1);
            Console.WriteLine();
            #endregion

            #region _8
            Console.WriteLine("8- check which number nearest to the value 100 among two given integers");
            int f8;
            do
            {
                f8 = 1;
                Console.WriteLine("enter your first integer");
                bool isFirstNumberValid = int.TryParse(Console.ReadLine(), out int n1);
                Console.WriteLine("enter your second integer");
                bool isSecondNumberValid = int.TryParse(Console.ReadLine(), out int n2);
                if (isFirstNumberValid && isSecondNumberValid)
                {
                    int diff1 = Math.Abs(100 - n1);
                    int diff2 = Math.Abs(100 - n1);
                    if (n1 == n2)
                    {
                        Console.WriteLine("0");
                    }
                    else
                    {
                        if (diff1 < diff2)
                        {
                            Console.WriteLine(n1);
                        }
                        else { Console.WriteLine(n2); }
                    }

                    Console.WriteLine("enter 0 to exit and 1 to continue");
                    f8 = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("enter valid number");
                }

            } while (f8 == 1);
            Console.WriteLine();
            #endregion

            #region _9
            Console.WriteLine("check whether two given integers are in the range 40..50 inclusive, or they are both in the range 50..60 inclusive.");
            int f9;
            do
            {
                f9 = 1;
                Console.WriteLine("enter first your integer");
                bool isFirstNumberValid = int.TryParse(Console.ReadLine(), out int n1);
                Console.WriteLine("enter second your integer");
                bool isSecondNumberValid = int.TryParse(Console.ReadLine(), out int n2);
                if (isFirstNumberValid)
                {
                    if (((n1 >= 40 && n1 <= 50) && (n2 >= 40 && n2 <= 50)) || ((n1 >= 50 && n1 <= 60) && (n2 >= 50 && n2 <= 60)))
                    {

                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");

                    }

                    Console.WriteLine("enter 0 to exit and 1 to continue");
                    f9 = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("enter valid number");
                }

            } while (f9 == 1);
            Console.WriteLine();
            #endregion

            #region _10
            Console.WriteLine("10- find the larger value from two positive integer \r\nvalues that is in the range 20..30 inclusive, or return 0 if neither is in that range.");
            int f10;
            do
            {
                f10 = 1;
                Console.WriteLine("enter first your integer");
                bool isFirstNumberValid = int.TryParse(Console.ReadLine(), out int n1);
                Console.WriteLine("enter second your integer");
                bool isSecondNumberValid = int.TryParse(Console.ReadLine(), out int n2);
                if (isFirstNumberValid)
                {
                    if (n1 >= 20 && n1 <= 30)
                    {
                        Console.WriteLine($"Maximum value =  {Math.Max(n1, n2)}");

                    }
                    else
                    {

                        Console.WriteLine("0");
                    }

                    Console.WriteLine("enter 0 to exit and 1 to continue");
                    f10 = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("enter valid number");
                }

            } while (f10 == 1);
            Console.WriteLine();
            #endregion

            #region _11
            Console.WriteLine("11- create a new string which is n (non-negative \r\ninteger) copies of a given string");
            int f11;
            do
            {
                f11 = 1;
                Console.WriteLine("enter your string");
                string s = Console.ReadLine();
                bool isN = int.TryParse(s, out int n1);
                Console.WriteLine("enter your integer");
                bool isNumberValid = int.TryParse(Console.ReadLine(), out int n);
                if (isNumberValid && n > 0 && !isN)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"{s}");
                    }
                    Console.WriteLine();
                    Console.WriteLine("enter 0 to exit and 1 to continue");
                    f11 = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write("enter valid number");
                }

            } while (f11 == 1);
            Console.WriteLine();
            #endregion

            #region _12
            Console.WriteLine("12-  program that accept two integers and return true if either one is 5 or their sum or difference is 5.");
            int f12;
            do
            {
                f12 = 1;
                Console.WriteLine("enter first your integer");
                bool isFirstNumberValid = int.TryParse(Console.ReadLine(), out int n1);
                Console.WriteLine("enter second your integer");
                bool isSecondNumberValid = int.TryParse(Console.ReadLine(), out int n2);
                if (isFirstNumberValid)
                {
                    if (n1 == 5 || n2 == 5 || n1 + n2 == 5 || n1 - n2 == 5)
                    {
                        Console.WriteLine("true");

                    }
                    else
                    {
                        Console.WriteLine("false");

                    }

                    Console.WriteLine("enter 0 to exit and 1 to continue");
                    f12 = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("enter valid number");
                }

            } while (f12 == 1);
            Console.WriteLine();
            #endregion

            #region _13
            Console.WriteLine("13- check if a given non-negative given number is amultiple of 3 or 7, but not both.");
            int f13;
            do
            {
                f13 = 1;
                Console.WriteLine("enter first your integer");
                bool isFirstNumberValid = int.TryParse(Console.ReadLine(), out int n);

                if (isFirstNumberValid && n > 0)
                {
                    if (n % 3 == 0 && n % 7 == 0)
                    {
                        Console.WriteLine("false");

                    }
                    else if (n % 3 == 0 || n % 7 == 0)
                    {
                        Console.WriteLine("true");
                    }
                    else { Console.WriteLine("false"); }

                    Console.WriteLine("enter 0 to exit and 1 to continue");
                    f13 = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("enter valid number");
                }

            } while (f13 == 1);
            Console.WriteLine();
            #endregion

            #region _14
            Console.WriteLine("program to check whether a given number is divisible by 3 \r\nreturn \"Fizz\" and return \"Buzz\" if it divisible by 5 and return \"FizzBuzz\" If it \r\ndivisible by 3 and 5");
            int f14;
            do
            {
                f14 = 1;
                Console.WriteLine("enter first your integer");
                bool isFirstNumberValid = int.TryParse(Console.ReadLine(), out int n);

                if (isFirstNumberValid)
                {
                    if (n % 3 == 0)
                    {
                        Console.WriteLine("Fizz");

                    }
                    else if (n % 5 == 0)
                    {
                        Console.WriteLine("Buzz");

                    }
                    else if (n % 3 == 0 && n % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }

                    Console.WriteLine("enter 0 to exit and 1 to continue");
                    f14 = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("enter valid number");
                }

            } while (f14 == 1);
            Console.WriteLine();
            #endregion

            #region _15
            Console.WriteLine("15- check if it is possible to add two integers to get the third integer from three given integers.");
            int f15;
            do
            {
                f15 = 1;
                Console.WriteLine("enter first your integer");
                bool isFirstNumberValid = int.TryParse(Console.ReadLine(), out int n1);
                Console.WriteLine("enter second your integer");
                bool isSecondNumberValid = int.TryParse(Console.ReadLine(), out int n2);
                Console.WriteLine("enter third your integer");
                bool isThirdNumberValid = int.TryParse(Console.ReadLine(), out int n3);
                if (isFirstNumberValid && isSecondNumberValid && isThirdNumberValid)
                {
                    if (n1 + n2 == n3 || n2 + n3 == n1 || n1 + n3 == n2)
                    {
                        Console.WriteLine("true");

                    }
                    else
                    {
                        Console.WriteLine("false");

                    }

                    Console.WriteLine("enter 0 to exit and 1 to continue");
                    f15 = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("enter valid number");
                }

            } while (f15 == 1);
            Console.WriteLine();
            #endregion

            #region _16
            Console.WriteLine("16- check if y is greater than x, and z is greater than \r\ny from three given integers x,y,z");
            int f16;
            do
            {
                f16 = 1;
                Console.WriteLine("enter first your integer");
                bool isFirstNumberValid = int.TryParse(Console.ReadLine(), out int x);
                Console.WriteLine("enter second your integer");
                bool isSecondNumberValid = int.TryParse(Console.ReadLine(), out int y);
                Console.WriteLine("enter third your integer");
                bool isThbirdNumberValid = int.TryParse(Console.ReadLine(), out int z);
                if (isFirstNumberValid)
                {
                    if (y > x && z > y)
                    {
                        Console.WriteLine("true");

                    }
                    else
                    {
                        Console.WriteLine("false");

                    }

                    Console.WriteLine("enter 0 to exit and 1 to continue");
                    f16 = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("enter valid number");
                }

            } while (f16 == 1);
            Console.WriteLine();
            #endregion

            #region _17
            Console.WriteLine("17- Multiplication Table");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i}*{j}={i * j} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion

            #region _18
            Console.WriteLine("18- max and min of them");
            int f18;
            do
            {
                f18 = 1;
                Console.WriteLine("enter first your integer");
                bool isFirstNumberValid = int.TryParse(Console.ReadLine(), out int n1);
                Console.WriteLine("enter second your integer");
                bool isSecondNumberValid = int.TryParse(Console.ReadLine(), out int n2);
                Console.WriteLine("enter second your integer");
                bool isThirdNumberValid = int.TryParse(Console.ReadLine(), out int n3);
                if (isFirstNumberValid && isSecondNumberValid && isThirdNumberValid)
                {

                    Console.WriteLine($"max: {Math.Max(Math.Max(n1, n2), n3)} min: {Math.Min(Math.Min(n1, n2), n3)}");
                    Console.WriteLine("enter 0 to exit and 1 to continue");
                    f18 = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("enter valid number");
                }

            } while (f18 == 1);
            Console.WriteLine();
            #endregion

            #region _19
            Console.WriteLine("19- receive positive numbers from user until summation of them reached or exceed 400");
            int sum;
            do
            {
                sum = 0;
                Console.WriteLine("enter your integer");
                bool isFirstNumberValid = int.TryParse(Console.ReadLine(), out int n);

                if (isFirstNumberValid)
                {
                    sum += n;
                }
                else
                {
                    Console.WriteLine("enter valid number");
                }

            } while (sum < 400);
            Console.WriteLine();
            #endregion

            #region _20
            Console.WriteLine("20 – display Selection Menu for user \r\n");
            string s = "o";
            do
            {
                Console.WriteLine("enter sign or 'e' for exit");
                s = Console.ReadLine();
                int n1, n2;
                switch (s)
                {
                    case "+":
                        Console.WriteLine("enter first num");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter second num");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"sum = {n1 + n2}");
                        break;
                    case "-":
                        Console.WriteLine("enter first num");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter second num");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"diff = {n1 - n2}");
                        break;
                    case "*":
                        Console.WriteLine("enter first num");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter second num");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"mul = {n1 * n2}");
                        break;
                    case "/":
                        Console.WriteLine("enter first num");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter second num");
                        bool div = int.TryParse(Console.ReadLine(), out int num);
                        if (num != 0)
                        {
                            Console.WriteLine($"div = {n1 / num}");
                        }
                        else
                        {
                            Console.WriteLine("you cant devide by 0");
                        }

                        break;
                    case "e":
                        s = "e";
                        break;
                    default:
                        Console.WriteLine("enter valid sign +, -, *, / or 'e' to exit");
                        break;
                }




            } while (s != "e");
            Console.WriteLine();
            #endregion

            #region _21
            Console.WriteLine("");
            int f21 = 1;
            do
            {
                Console.WriteLine("Enter first positive integer:");
                bool isFirstNumberValid = int.TryParse(Console.ReadLine(), out int n1);

                Console.WriteLine("Enter second positive integer:");
                bool isSecondNumberValid = int.TryParse(Console.ReadLine(), out int n2);

                if (!isFirstNumberValid || !isSecondNumberValid || n1 <= 0 || n2 <= 0 || n1 == n2)
                {
                    Console.WriteLine("Please enter two different positive numbers.");
                    continue;
                }

                
                int start = Math.Min(n1, n2);
                int end = Math.Max(n1, n2);

                int sumEven = 0, sumOdd = 0;

                Console.Write("Even : ");
                for (int i = start; i <= end; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i);
                        sumEven += i;
                        if (i < end && i + 1 <= end) Console.Write(","); 
                    }
                }
                Console.WriteLine($"\nSum of Even = {sumEven}");

                Console.Write("Odd : ");
                for (int i = start; i <= end; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(i);
                        sumOdd += i;
                        if (i < end && i + 2 <= end) Console.Write(","); 
                    }
                }
                Console.WriteLine($"\nSum of Odd = {sumOdd}");

                int diff = Math.Abs(sumEven - sumOdd);
                Console.WriteLine($"EvenSummation – OddSummation = {sumEven} – {sumOdd} = {diff}");

                Console.WriteLine("Enter 0 to exit or 1 to continue:");
                f21 = int.Parse(Console.ReadLine());

            } while (f21 == 1);
            Console.WriteLine();
            #endregion


        }
    }
}
