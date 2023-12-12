using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kgLab
{
    internal class HSLColor
    {
        public double H { get; set; }
        public double S { get; set; }
        public double L { get; set; }
        public HSLColor(double h, double s, double l)
        {
            H = h;
            S = s;
            L = l;
        }
        public static HSLColor FromRGB(Color color)
        {
            double R = color.R / 255.0;
            double G = color.G / 255.0;
            double B = color.B / 255.0;
            double _max = Math.Max(Math.Max(R, G), B);
            double _min = Math.Min(Math.Min(R, G), B);
            double diff = _max - _min;

            double _H, _S, _L;
            _L = (_max + _min) / 2.0;

            if (_L == 0 || diff == 0)
            {
                _S = 0;
            }
            else if (_L < 1.0 / 2.0)
            {
                _S = diff / (2 * _L);
            }
            else
            {
                _S = diff / (2.0 - 2 * _L);
            }

            if (diff == 0)
            {
                _H = 0;
            }
            else if (R == _max)
            {
                _H = ((60 * ((G - B) / diff) + 360) % 360) / 360;
            }
            else if (G == _max)
            {
                _H = ((60 * ((B - R) / diff) + 120) % 360) / 360;
            }
            else
            {
                _H = ((60 * ((R - G) / diff) + 240) % 360) / 360;
            }
            return new HSLColor(_H, _S, _L);
        }
        public Color ToRGB()
        {
            double TR, TG, TB, Q, P;
            if(L<0.5)
            {
                Q = L * (1.0 + S);
            }
            else
            {
                Q = L + S - (L * S);
            }
            P = 2.0 * L - Q;
            TR = H + (1.0 / 3.0);
            TG = H;
            TB = H - (1.0 / 3.0);
            
            return Color.FromArgb(
                (byte)(TcToC(TR, P, Q) * 255),
                (byte)(TcToC(TG, P, Q) * 255),
                (byte)(TcToC(TB, P, Q) * 255)
            );
        }
        double TcToC(double Tc, double P, double Q)
        {
            if (Tc < 0)
            {
                Tc = Tc + 1.0;
            }
            if(Tc>1)
            {
                Tc = Tc - 1.0;
            }
            if(Tc<(1.0/6.0))
            {
                return P + ((Q - P) * 6.0 * Tc);
            }
            if(Tc<(1.0/2.0))
            {
                return Q;
            }
            if(Tc<(2.0/3.0))
            {
                return P + ((Q - P) * ((2.0 / 3.0) - Tc) * 6.0);
            }
            return P;
        }
    }
}
