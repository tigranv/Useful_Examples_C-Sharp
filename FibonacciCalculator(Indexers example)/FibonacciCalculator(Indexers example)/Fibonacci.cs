using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciCalculator_Indexers_example_
{
    public class Fibonacci
    {
        public Fibonacci(int l)
        {
            if(l>16 || l<0) throw new ArgumentOutOfRangeException();
            length = l;
            Fibonac = new int[l];
            Fibonac[0] = 0;
            Fibonac[1] = 1;
            for (int i = 2; i < l; i++)
            {
                Fibonac[i] = Fibonac[i - 1] + Fibonac[i - 2];
            }
        }

        private int[] Fibonac;
        private int length;

        public int this[int index]
        {
            get
            {              
                if (index >=0 && index <= length) return Fibonac[index];
                throw new ArgumentOutOfRangeException();
            }
        }

    }
}
