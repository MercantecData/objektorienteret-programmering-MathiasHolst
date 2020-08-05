using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadingMath
{
    class Math
    {
        public float plus(float a, float b)
        {
            return a + b;
        }

        public int plus(int a, int b)
        {
            return a + b;
        }

        public string plus(string a, string b)
        {
            return a + b;
        }

        public float minus(float a, float b)
        {
            return a - b;
        }

        public int minus(int a, int b)
        {
            return a - b;
        }

        public string minus(string a, string b)
        {
            int c = int.Parse(a) - int.Parse(b);
            return c.ToString();
        }

        public float gange(float a, float b)
        {
            return a * b;
        }

        public int gange(int a, int b)
        {
            return a * b;
        }

        public string gange(string a, string b)
        {
            int c = int.Parse(a) * int.Parse(b);
            return c.ToString();
        }

        public float divider(float a, float b)
        {
            return a / b;
        }

        public int divider(int a, int b)
        {
            return a / b;
        }

        public string divider(string a, string b)
        {
            int c = int.Parse(a) / int.Parse(b);
            return c.ToString();
        }

        public float potens(float a, float b)
        {
            return MathF.Pow(a, b);
        }

        public int potens(int a, int b)
        {
            float c = MathF.Pow((float)a, (float)b);
            return Convert.ToInt32(c);
        }

        public string potens(string a, string b)
        {
            int c = int.Parse(a);
            int d = int.Parse(b);
            float e = MathF.Pow((float)c, (float)d);
            return e.ToString();
        }

        public float kvadratrod(float a)
        {
            return MathF.Sqrt(a);
        }

        public int kvadratrod(int a)
        {
            float b = MathF.Sqrt((float)a);
            return Convert.ToInt32(b);
        }

        public string kvadratrod(string a)
        {
            int b = int.Parse(a);
            float c = MathF.Sqrt((float)b);
            return c.ToString();
        }
    }
}
