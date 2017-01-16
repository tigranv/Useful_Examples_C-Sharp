using System;
using System.Diagnostics;
using System.Collections;

namespace From4BytesToInt32Methods
{
    class Program
    {
        // First method to convert 4 bytes to int32, by converting at first to binary string
        public static int FromByteToInt1(byte a, byte b, byte c, byte d)
        {
            string s = Convert.ToString(d, 2).PadLeft(8, '0') + Convert.ToString(c, 2).PadLeft(8, '0') + 
                Convert.ToString(b, 2).PadLeft(8, '0') + Convert.ToString(a, 2).PadLeft(8, '0');
            var decim = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[s.Length - i - 1] == '0') continue;
                decim += (int)Math.Pow(2, i);
            }
            return decim;
        }

        // Second method to convert 4 bytes to int32, by converting at first to bitarray
        public static int FromByteToInt2(byte a, byte b, byte c, byte d)
        {
            var bits = new BitArray(new byte[] { a, b, c, d });

            var decim = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                if (!bits[i]) continue;
                decim += (int)Math.Pow(2, i);
            }
            return decim;
        }

        // compaering two methods with ToInt32
        static void Main(string[] args)
        {
            // Calculating the execution time of a method ToInt32 for 1000000 iterations
            byte[] arr = new byte[4] { 1, 2, 3, 4 };
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < 1000000; i++)
            {
                var seed = BitConverter.ToInt32(arr, 0);
            }
            Console.Write("Execution time of a method ToInt32 for 1000000 iterations is ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("->{0}<- miliseconds", sw.ElapsedMilliseconds);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1+2+3+4 --> {0}", BitConverter.ToInt32(arr, 0));


            // Calculating the execution time of a method FromByteToInt1 for 1000000 iterations
            Stopwatch sw2 = Stopwatch.StartNew();
            for (int i = 0; i < 1000000; i++)
            {
                FromByteToInt1(1, 2, 3, 4);
            }
            Console.Write("Execution time of a method FromByteToInt1 for 1000000 iterations is ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("->{0}<- miliseconds", sw2.ElapsedMilliseconds);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1+2+3+4 --> {0}", FromByteToInt1(1, 2, 3, 4));


            // Calculating the execution time of a method FromByteToInt2 for 1000000 iterations
            Stopwatch sw3 = Stopwatch.StartNew();
            for (int i = 0; i < 1000000; i++)
            {
                FromByteToInt1(1, 2, 3, 4);
            }
            Console.Write("Execution time of a method FromByteToInt2 for 1000000 iterations is ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("->{0}<- miliseconds", sw3.ElapsedMilliseconds);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1+2+3+4 --> {0}", FromByteToInt2(1, 2, 3, 4));



            Console.ReadKey();
        }
    }
}
