using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKeyEvent
{
    public delegate void PressKeyEventHandler();

    public class Keyboard
    {
        public event PressKeyEventHandler PressKeyA = null;
        public event PressKeyEventHandler PressKeyB = null;
        //  C ... Z

        public void PressKeyAEvent()
        {
            if (PressKeyA != null)
            {
                PressKeyA.Invoke(); 
            }
        }

        public void PressKeyBEvent()
        {
            if (PressKeyB != null)
            {
                PressKeyB.Invoke();
            }
        }

        public void Start()
        {
            while (true)
            {
                string s = Console.ReadLine();

                switch (s)
                {
                    case "a":
                    case "A":
                        PressKeyAEvent();
                        break;
                    case "b":
                    case "B":
                        PressKeyBEvent();
                        break;
                    case "exit":
                        goto Exit;

                    default:
                        Console.WriteLine("No event handler for key {0}", s);
                        break;
                }
            }
            Exit:
            Console.WriteLine("Exit!");
        }
    }

    class Program
    {
        // Методы обработчики события.

        static private void PressKeyA_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("    X    ");
            Console.WriteLine("   X X   ");
            Console.WriteLine("  X   X  ");
            Console.WriteLine(" XXXXXXX ");
            Console.WriteLine("X       X");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static private void PressKeyB_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("XXXXX  ");
            Console.WriteLine("X    X ");
            Console.WriteLine("XXXXXX ");
            Console.WriteLine("X     X");
            Console.WriteLine("XXXXXX ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void Main()
        {
            Keyboard keyboard = new Keyboard();

            // methods to event.
            keyboard.PressKeyA += new PressKeyEventHandler(PressKeyA_Handler);
            keyboard.PressKeyB += PressKeyB_Handler;
            while (true)

                keyboard.Start();
        }
    }
}
