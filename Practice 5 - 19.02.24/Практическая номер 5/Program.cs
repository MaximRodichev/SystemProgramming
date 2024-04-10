using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Instructs.Instructions;
using static System.Console;
using static Functions.Practic1;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace Практическая_номер_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Limit >3
            bool CheckToArithmetical(int a)
            {
                if (a < 100) { throw new Exception("Number is lower then 100"); }
                List<int> digits = GetListofDigits(a); digits.Reverse();
                List<int> k = new List<int>();
                for(int i = 0; i < digits.Count-1; i++)
                {
                    k.Add(digits[i] - digits[i+1]);
                }
                return k.Distinct().Count() == 1;
            }



            void Task1()
            {
                int chislo = inputInt("Get me number(upper 100): ");
                try
                {
                    info($"OUTPUT: {CheckToArithmetical(chislo)}");
                }
                catch(Exception e) { Error($"{e.Message}"); }
            }

            void writeRectangle(int[] startPoint, int width, int height, ConsoleColor color = ConsoleColor.Black)
            {
                Console.ForegroundColor = color;
                int x = startPoint[0]; int y = startPoint[1];
                
                for (int h = 0; h <= height; h++)
                {
                    Console.SetCursorPosition(x, y+h);
                    if (h == 0 || h == height) {
                        foreach (int i in Enumerable.Range(0, width))
                        { Write($"* "); }
                    }
                    else {
                        Write("* ");
                        foreach (int i in Enumerable.Range(0, width-2))
                        { Write($"  "); }
                        Write("* ");
                    }
                }
                Console.ResetColor();
            }

            void Task2()
            {
                
                int widthTable = 10; int heightTable = 6;
                var temp = inputString("Laptop1 Width, Height: ").Trim().Split(',');
                int[] Laptop1 = new int[] { Convert.ToInt32(temp[0]), Convert.ToInt32(temp[1]) };
                temp = inputString("Laptop2 Width, Height: ").Split(',');
                int[] Laptop2 = new int[] { Convert.ToInt32(temp[0]), Convert.ToInt32(temp[1]) };
                Array.Sort(Laptop1);
                Array.Sort(Laptop2);
                int verstS = (Laptop1[0] + Laptop2[0]) * (Laptop2[1] >= Laptop1[1] ? Laptop2[1] : Laptop1[1]);
                int vtorS = (Laptop1[1] + Laptop2[1]) * (Laptop2[0] >= Laptop1[0] ? Laptop2[0] : Laptop1[0]);

                if (verstS < vtorS) { widthTable = Laptop1[0] + Laptop2[0]; heightTable = Laptop2[1] >= Laptop1[1] ? Laptop2[1] : Laptop1[1]; }
                else { widthTable = Laptop1[1] + Laptop2[1]; heightTable = Laptop2[0] >= Laptop1[0] ? Laptop2[0] : Laptop1[0]; }

                int Left = CursorLeft; int Top = CursorTop;
                writeRectangle(new int[] { Left, Top }, widthTable, heightTable, ConsoleColor.DarkRed);
                
                
                info($"\nLaptop 1\tW: {Laptop1[0]}\tH: {Laptop1[1]}\nLaptop 2\tW: {Laptop2[0]}\tH: {Laptop2[1]}\nwTable: {widthTable}\t|\thTable: {heightTable}\nverstS: {verstS}\t|\tvtorS: {vtorS}");



            }


            void Task3()
            {
                info($"{((double)(inputInt("K: ") * (inputInt("N: ") - 1))/100):f2}cm");
            }

            void Task4()
            {
                int M = inputInt("M: ");
                int N = inputInt("N: ");
                List<int[]> array = new List<int[]>();
                int c = 0;
                do
                {
                    string[] item = inputString("Size: ").Trim().Split(',');
                    int[] temp = new int[2] { Convert.ToInt32(item[0]), Convert.ToInt32(item[1]) };
                    int[] range = Enumerable.Range(temp[0], temp[1] - temp[0]+1).ToArray();
                    foreach(var g in range) { info($"{g}"); }
                    foreach(var x in array)
                    {
                        info($"x[0]: {(range.Contains(x[0]))}\nx[1]: {(range.Contains(x[1]))}\n{(range.Contains(x[0]) == false) && (range.Contains(x[1]) == false)}");
                    }
                    array = array.Where(x => (range.Contains(x[0]) == false) && (range.Contains(x[1])==false)).ToList();
                    array.Add(temp);
                    c++;
                }
                while (c<N);
                foreach(var i in Enumerable.Range(0, array.Count))
                {
                    int[] range = Enumerable.Range(array[i][0], array[i][1]).ToArray();
                    
                }
                foreach (var i in array) info($"{i[0]}\t|\t{i[1]}");

            }

            Action[] actions =
            {
                ()=>Task1(),
                ()=>Task2(),
                ()=>Task3(),
                ()=>Task4()
            };
            WorkList(actions);
            ReadLine();

        }
    }
}
