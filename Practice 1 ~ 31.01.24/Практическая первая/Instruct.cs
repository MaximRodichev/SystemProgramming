using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Instruct
{
    internal class Instructions
    {
        public static int inputInt(string txt)
        {
        inputError:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(txt);
            Console.ForegroundColor = ConsoleColor.Red;
            int a;
            if (!int.TryParse(Console.ReadLine(), out a)) { goto inputError; }
            else
            {

                Console.ResetColor();
                return a;
            }
        }

        public static string inputString(string txt)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(txt);
            Console.ForegroundColor = ConsoleColor.Red;
            string a = Console.ReadLine();
            Console.ResetColor();
            return a;
        }

        public static void info(string txt, ConsoleColor a = ConsoleColor.Yellow)
        {
            Console.ForegroundColor = a;
            Console.Write(txt + "\n");
            Console.ResetColor();
        }
        public static void Error(string txt, ConsoleColor a = ConsoleColor.Red)
        {
            Console.ForegroundColor = a;
            Console.Write(txt + "\n");
            Console.ResetColor();
        }

        public static void WorkList(Action[] actions)
        {again:
            byte target;
            bool targetB = byte.TryParse(inputString("Hello, what do you want to check? Enter the task number (zero is exit): "), out target);
            if (!targetB) { info("Error input Data"); goto again; }
            if (target == 0) { Error("Check my homework is over. Any key to exit"); Console.ReadLine(); }
            else if (target >= 1 && target <= actions.Length)
            {
            againTask:
                actions[target - 1]();
                Error("Enter to again this Task");
                if(Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    goto againTask;
                }
                goto again;
            }
            else
            {
                info("Invalid task number, please Write Correctly: ");
                goto again;
            }
        }

    }
}
