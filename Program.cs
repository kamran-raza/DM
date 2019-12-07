using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastModularExp
{

    /*Fast Modular Exponentiation */
    class Program
    {
        static void Main(string[] args)


        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                            Fast Modular Exponentiation Program                       ");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("                            Submitted by Kamran Raza (ID: 63987) \n");


            Console.WriteLine("About this program: This program will ask three integer values Base, Exponent and Modular and returns B^K(mod M) \n \n");

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Enter Base Value (B): ");
             
            long B = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter Exponent (K): ");
            long K = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter Modular (M): ");
            long M = Convert.ToInt32(Console.ReadLine());
                        
            Console.WriteLine("\nB^K(mod M): {0}", bkmodm(B,K,M) );
            Console.ReadKey();

        }
        
        // Calculate (b^k) % m 
        public static long bkmodm(long b, long k, long m)
        {
            long ans = BPowK(b, k); //Function to calculate power of any number (b^k)
            long mul = ans % m;

            return mul;
        }

        // Calculate (b^k)
        public static long BPowK(long b, long k)
        {
            if (k == 0)
                return 1;
            else
                return b * BPowK(b, k - 1);
        }



    }
}
