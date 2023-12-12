using System;
using System.Numerics;

namespace kgLab
{
    internal class AberthMethod
    {
        public static Complex[] FindRoots(Complex[] list, Complex eqConst)
        {
            Complex[] previous = list;
            Complex[] current = new Complex[previous.Length];
            for (int i = 0; i < previous.Length; i++)
            {
                if (Derivative(previous[i]) == 0) return list;
                current[i] = Iteration(previous, eqConst, i);
            }
            int iteration = 0;
            while (!EndInteration(current, previous) && iteration < 200)
            {
                previous = current;
                for (int i = 0; i < previous.Length; i++)
                {
                    if (Derivative(previous[i]) == 0) return previous;
                    current[i] = Iteration(previous, eqConst, i);
                }
                iteration++;
            }
            return current;
        }
        private static Complex Function(Complex a, Complex c)
        {
            return Complex.Pow(a, new Complex(5, 0)) + c;
            //return 4 * Complex.Pow(a, new Complex(5, 0)) - 8 * Complex.Pow(a, new Complex(4, 0)) + 2 * Complex.Pow(a, new Complex(2, 0)) + 6 * Complex.Pow(a, new Complex(1, 0)) + c;
        }
        private static Complex Derivative(Complex a)
        {
            return 5 * Complex.Pow(a, new Complex(4, 0));
            //return 20 * Complex.Pow(a, new Complex(4, 0)) - 32 * Complex.Pow(a, new Complex(3, 0)) + 4 * Complex.Pow(a, new Complex(1, 0)) + 6;
        }
        private static Complex InvertSum(Complex[] list, int index)
        {
            Complex sum = Complex.Zero;

            for (int i = 0; i < list.Length; i++)
            {
                if (i != index)
                {
                    sum += 1 / (list[index] - list[i]);
                }
            }
            return sum;
        }
        private static bool EndInteration(Complex[] current, Complex[] previous)
        {
            for (int i = 0; i < current.Length; i++)
                if (Math.Abs((current[i] - previous[i]).Magnitude) > 0.0001)
                    return false;
            return true;
        }
        private static Complex Iteration(Complex[] previous, Complex c, int index)
        {
            Complex numerator = Function(previous[index], c) / Derivative(previous[index]);
            Complex denominator = 1 - (Function(previous[index], c) / Derivative(previous[index]) * InvertSum(previous, index));
            return previous[index] - numerator / denominator;
        }
    }
}
