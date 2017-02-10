using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NeoMatrix
{

    class Program
    {
        static void Main(string[] args)
        {
            
            //ParameterizedThreadStart task = new ParameterizedThreadStart(Operator);

            Thread Task = new Thread(Operator);
            Task.IsBackground = false;
            Task.Start(400);


            int i = 400;
            while (i > 0)
            {
                Console.WriteLine("arajnayin");
                i--;
            }


        }

        static void Operator(object a)
        {
            int i = (int)a;
            while (true)
            {
                Console.WriteLine("\t\tErkrordakan hosq");
                i--;
            }
        }
    }
}
