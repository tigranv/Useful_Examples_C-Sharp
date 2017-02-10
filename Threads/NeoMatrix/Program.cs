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
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 42);

            MatrixBuilder instance;

            for (int i = 0; i < 26; i++)
            {
                instance = new MatrixBuilder(i * 3, true);
                new Thread(instance.Move).Start();
            }

        }

    }
}
