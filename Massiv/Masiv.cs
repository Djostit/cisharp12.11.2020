using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massiv
{
    public class Masiv
    {
        public void InputMass(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{1 + i}-е число: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public void OutputMass(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        public int SumMass(int[] a)
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                s += a[i];
            }
            return s;
        }
    }
}
