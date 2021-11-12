using System;

namespace Massivv
{
    public class Massiv
    {
        static void InputMass(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{1 + i}-е число: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void OutputMass(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        static int SumMass(int[] a)
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
