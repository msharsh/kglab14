using System;
using System.Numerics;

namespace kgLab
{
    internal class NewtonsMethod
    {
        public static Complex FindRoot(Complex number, Complex eqConst)
        {
            Complex previous = number;
            if (Derivative(previous) == 0) return number;
            Complex current = Iteration(previous, eqConst);
            int iteration = 0;
            while (Math.Abs((previous - current).Magnitude) > 0.0001 && iteration < 50 && Derivative(previous) != 0)
            {
                previous = current;
                current = Iteration(previous, eqConst);
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
        private static Complex Iteration(Complex previous, Complex c)
        {
            return previous - Function(previous, c) / Derivative(previous);
        }
    }
}
