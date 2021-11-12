using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Massiv;

namespace _12._111._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Masiv o = new Masiv();
            Console.Write("n1: ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            o.InputMass(A);

            Console.Write("n2: ");
            int n2 = int.Parse(Console.ReadLine());
            int[] B = new int[n2];
            o.InputMass(B);

            Console.Write("n3: ");
            int n3 = int.Parse(Console.ReadLine());
            int[] C = new int[n2];
            o.InputMass(C);

            if (o.SumMass(A) >= o.SumMass(B) && o.SumMass(A) >= o.SumMass(C))
            {
                o.OutputMass(A);
            }
            else if (o.SumMass(B) >= o.SumMass(A) && o.SumMass(B) >= o.SumMass(C))
            {
                o.OutputMass(B);
            }
            else if (o.SumMass(C) >= o.SumMass(A) && o.SumMass(C) >= o.SumMass(B))
            {
                o.OutputMass(C);
            }
            Console.ReadKey();
        }
    }
}
