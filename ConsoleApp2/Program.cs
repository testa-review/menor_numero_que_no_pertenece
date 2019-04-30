using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Debug.WriteLine("hola");
            //Console.ReadKey(true);
            int[] datosFechaActual = new Int32[] { 1,2,3 };

            solution(datosFechaActual);

        }

        public static int solution(int[] aa)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int res = 1;
            Array.Sort(aa);

            for (int i = 0; i < aa.Length-1; i++)
            {
                if (Math.Abs(aa[i + 1]) > Math.Abs(aa[i]+1)) res = aa[i] + 1;
            }

            if (aa.Contains(res)) res = aa[aa.Length - 1]+1;


            Debug.WriteLine("res: "+res);
            return res;
        }

        /*This is a demo task.

        Write a function:

        class Solution { public int solution(int[] A); }

        that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

        For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

        Given A = [1, 2, 3], the function should return 4.

        Given A = [−1, −3], the function should return 1.

        Write an efficient algorithm for the following assumptions:

        N is an integer within the range [1..100,000];
        each element of array A is an integer within the range [−1,000,000..1,000,000]. 
         
         */
    }
}
