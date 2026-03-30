using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class Program
    {
        #region _2
        // functions 
        static void FillArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"enter value {i + 1} of the array = ");
                arr[i] = int.Parse(Console.ReadLine());

            }
            return;
        }

        static void DisplayArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"value {i} = {arr[i]}");
            }
            return;
        }

        static int[] GetOdd(int[] arr)
        {
            int[] odd = new int[arr.Length];
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    odd[i] = arr[i];
                }
            }

            for (int i = 0; i < odd.Length; i++)
            {
                if (odd[i] != 0)
                {
                    count++;
                }
            }

            int[] fArr = new int[count];
            int index = 0;

            for (int i = 0; i < odd.Length; i++)
            {
                if (odd[i] != 0)
                {
                    fArr[index] = odd[i];
                    index++;
                }
            }
            return fArr;
        }

        static int[] GetEven(int[] arr)
        {
            int[] odd = new int[arr.Length];
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    odd[i] = arr[i];
                }
            }

            for (int i = 0; i < odd.Length; i++)
            {
                if (odd[i] != 0)
                {
                    count++;
                }
            }

            int[] fArr = new int[count];
            int index = 0;

            for (int i = 0; i < odd.Length; i++)
            {
                if (odd[i] != 0)
                {
                    fArr[index] = odd[i];
                    index++;
                }
            }
            return fArr;
        }

        static int GetMax(int[] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                max = Math.Max(max, arr[i]);
            }
            return max;
        }

        static int GetMin(int[] arr)
        {
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                min = Math.Min(min, arr[i]);
            }
            return min;
        }

        static int GetAvg(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }

        static void question_2()
        {
            Console.Write("enter your 1D array size = ");
            int n = int.Parse(Console.ReadLine());
            int[] myArr = new int[n];
            FillArray(myArr, n);
            Console.WriteLine("------------ your array ------------");
            DisplayArray(myArr);
            Console.WriteLine("------------ your odd number ------------");
            DisplayArray(GetOdd(myArr));
            Console.WriteLine("------------ your even numbers ------------");
            DisplayArray(GetEven(myArr));
            Console.WriteLine("------------ your max number ------------");
            Console.WriteLine(GetMax(myArr));
            Console.WriteLine("------------ your min number ------------");
            Console.WriteLine(GetMin(myArr));
            Console.WriteLine("------------ your avg number ------------");
            Console.WriteLine(GetAvg(myArr));
        }
        #endregion

        #region _3
        static void Fill2DArray(int[,] arr, int d1, int d2)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"enter value {j} of the array of row {i} = ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return;
        }

        static void Display2DArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write($"row {i} :");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($" {arr[i, j]}");
                }
                Console.WriteLine();

            }
            return;
        }

        static void Get2DRowSummation(int[,] arr)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int sum = 0;
       
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i,j];
                }
                Console.WriteLine($"summation of row {i+1} in 2D array = {sum}");

            }
            return;
        }

        static void GetAvg2DColumns(int[,] arr)
        {
            // arr[0,0]
            // arr[1,0]
            // arr[2,0]
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                int sum = 0;

                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    sum += arr[j,i];
                }
                Console.WriteLine($"average of col {i + 1} in 2D array = {sum/arr.GetLength(0)}");

            }
            return;
        }

        static void question_3()
        {
            Console.Write("enter your 1_st D array size = ");
            int d1 = int.Parse(Console.ReadLine());
            Console.Write("enter your 2_nd D array size = ");
            int d2 = int.Parse(Console.ReadLine());
            int[,] myArr = new int[d1, d2];
            Fill2DArray(myArr, d1, d2);
            Console.WriteLine("------------ your 2D array ------------");
            Display2DArray(myArr);
            Console.WriteLine("------------ summation of each row ------------");
            Get2DRowSummation(myArr);
            Console.WriteLine("------------ average of each col ------------");
            GetAvg2DColumns(myArr);
        }
        #endregion

        #region _4
        static void question_4()
        {
            int f = 1;
            do
            {
                question_3();
                Console.WriteLine("enter 0 to exit or any other number to repeat");
                f = int.Parse(Console.ReadLine());
            } while (f != 1);
        }
        #endregion

        #region _5
        static int[] concatResult(int[] arr1, int[] arr2)
        {
            int n = arr1.Length + arr2.Length;
            int[] res = arr1.Concat(arr2).ToArray();

            return res;
        }

        static void question_5()
        {
            int[] arr1 = { 1, 2, 3, 4 };
            int[] arr2 = { 20, 30, 40, 50 };
            Console.WriteLine("------------ concat two arrays ------------");
            Console.WriteLine(string.Join(",", concatResult(arr1, arr2)));
        }
        #endregion

        #region _6
        static void countRepeating(int[] arr)
        {
            int n = GetMax(arr) + 1;
            int[] freq = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                freq[arr[i]]++;
            }
            for(int i = 0; i <= n; i++)
            {
                if (freq[i] > 0)
                {
                    Console.WriteLine($"{i} occurs {freq[i]} times");
                }
            }
        }

        static void question_6()
        {
            int[] arr = { 1, 2, 1 };
            countRepeating(arr);
        }
        #endregion

        #region _7
        static void CheckUnique(int[] arr)
        {
            int n = GetMax(arr) +1;
            int[] freq = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                freq[arr[i]]++;
            }
            for (int i = 0; i <= n; i++)
            {
                if (freq[i] == 1)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
        static void question_7()
        {
            Console.Write("enter your 1D array size = ");
            int n = int.Parse(Console.ReadLine());
            int[] myArr = new int[n];
            FillArray(myArr, n);
            Console.WriteLine("------------ your Unique numbers in the array ------------");
            CheckUnique(myArr);
        }
        #endregion

        #region _8
        static double GetPower(int n1, int n2)
        {
            double ans = Math.Pow(n1, n2); 
            return ans;
        }
        static void question_8()
        {
            Console.WriteLine("------------ GetPower ------------");
            Console.Write("enter your first number = ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("enter your first number = ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(GetPower(n1, n2)); ;
        }
        #endregion

        #region _9
        static void CheckPrime(int n)
        {
            if(n % 2 != 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        static void question_9()
        {
            Console.WriteLine("------------ checkPrime ------------");
            Console.Write("enter your number = ");
            int n1 = int.Parse(Console.ReadLine());

            CheckPrime(n1);
        }
        #endregion

        #region _11
        static int GetFactorial(int n)
        {
            int ans = 1;
            for(int i = 1; i <= n; i++) { 
                ans *= i;
            }
            return ans;
        }
        static void question_11()
        {
            Console.WriteLine("------------ GetFactorial ------------");
            Console.Write("enter your number = ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFactorial(n1));
        }
        #endregion
        
        #region _12
        static int longestDistance(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j] && (j-i-1) > max)
                    {
                        max = j - i - 1;
                    }
                }
            }
            return max;
        }
        static void question_12()
        {
            Console.Write("enter your 1D array size = ");
            int n = int.Parse(Console.ReadLine());
            int[] myArr = new int[n];
            FillArray(myArr, n);
            Console.WriteLine("------------  longest distance between Two equal cells ------------");
            Console.WriteLine(longestDistance(myArr));

        }
        #endregion

        static void Main(string[] args)
            {
            Console.WriteLine("******** question_2 ********");
            question_2();

            Console.WriteLine();
            Console.WriteLine("******** question_3 ********");
            question_3();

            Console.WriteLine();
            Console.WriteLine("******** question_4 ********");
            question_4();

            Console.WriteLine();
            Console.WriteLine("******** question_5 ********");
            question_5();

            Console.WriteLine();
            Console.WriteLine("******** question_6 ********");
            question_6();

            Console.WriteLine();
            Console.WriteLine("******** question_7 ********");
            question_7();

            Console.WriteLine();
            Console.WriteLine("******** question_8 ********");
            question_8();

            Console.WriteLine();
            Console.WriteLine("******** question_9 ********");
            question_9();

            Console.WriteLine();
            Console.WriteLine("******** question_11 ********");
            question_11();

            Console.WriteLine();
            Console.WriteLine("******** question_12 ********");
            question_12();
        }
        }
    }

