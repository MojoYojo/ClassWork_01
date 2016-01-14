using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Complex
    {
        public int a, b;

        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public override string ToString()
        {
            return a + "/" + b;
        }

        public Complex add(Complex c)
        {
            Complex result = new Complex(this.a + c.a, this.b + c.b);
            return result;
        }

        public Complex substract(Complex c)
        {
            Complex result = new Complex(this.a - c.a, this.b - c.b);
            return result;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex(5, 6);
            Complex d = new Complex(5, 7);
            Complex w = c.add(d);
            Console.WriteLine(w);
            Console.ReadKey();
        }
    }
}
