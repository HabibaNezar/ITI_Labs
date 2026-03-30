using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Hello World");

            //2
            
            string s2;
            while (true)
            {
                Console.WriteLine("enter your char");
                s2 = Console.ReadLine();
                if(s2.Length == 1 && !int.TryParse(s2, out int num))
                {
                    Console.WriteLine((int)char.Parse(s2));
                    break;
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            };
   

            //3
            
            string s3 ;
            while (true)
            {
                Console.WriteLine("Enter your ASCI");
                s3 = Console.ReadLine();
                if(int.TryParse(s3, out int num))
                {
                    Console.WriteLine((char)num);
                    break;
                }
                else { Console.WriteLine("invalid input"); }

            }
            

            //4
            
            string s4;
            while (true)
            {
                Console.WriteLine("Enter your integer");
                s4 = Console.ReadLine();
                if (int.TryParse(s3, out int num))
                {
                    Console.WriteLine($"Hexadecimal = {num:X}");
                    break;
                }
                else { Console.WriteLine("invalid input"); }

            }


            //5
            while (true)
            {
                Console.WriteLine("Enter your first number");
                string in1 = Console.ReadLine();
                if (int.TryParse(in1, out int n1)){
                    
                    while (true)
                    {
                        Console.WriteLine("Enter your second number");
                        string in2 = Console.ReadLine();
                        if (int.TryParse(in2, out int n2)){
                            Console.WriteLine($"summ = {n1 + n2}");
                            Console.WriteLine($"subtraction = {n1 - n2}");
                            Console.WriteLine($"multiplication = {n1 * n2}");
                            break;
                        }
                        else { Console.WriteLine("invalid second number"); }
                    }
                    break;

                }
                else
                {
                    Console.WriteLine("invalid first number");
                }
            }
            
            
           
            
        }
    }
}
