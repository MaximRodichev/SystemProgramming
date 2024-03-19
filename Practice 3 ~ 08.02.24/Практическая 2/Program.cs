using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Практическая_3
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34
            List<int> Generate(long K)
            {
                List<int> output = new List<int>();
                output.Add(0);
                output.Add(1);
                for (int i = 0; i <= K-2; i++)
                {
                    output.Add(output[output.Count-1]+ output[output.Count - 2]);
                }
                return output;
            }
            int How(int M, long K)
            {
                int counter = 0;
                var items = Generate(K);
                foreach (int item in items)
                {
                    if(item % M == 0) counter++;
                }
                Instructions.info($"{string.Join(", ", items)}");
                return counter;
            }

            // A>B (get A%B) without math
            int WithoutMath_(int A, int B){
                if(A <= B) { throw new Exception("A is lower then or equals B"); }
                else
                {
                    int a;
                    for (a = 0; A>=B*a; a++) { }
                    return A-(B*(a-1));
                }
            }

            void Task1()
            {
                againM:
                int M = Instructions.inputInt("Get me M: ");
                if(M<0 || M>Math.Pow(10, 6)) { Instructions.info("M out of diaposone"); goto againM; }
            againK:
                long K = long.Parse(Instructions.inputString("Get me K: "));
                if (K < 0 || K > Math.Pow(10, 18)) { Instructions.info("K out of diaposone"); goto againK; }
                Instructions.info($"{How(M, K)}");
            }

            void Task2()
            {
            againTask:
                int A = Instructions.inputInt("A: ");
                if (A < 0) { Instructions.info("A is lower then zero"); goto againTask; }
            againB:
                int B = Instructions.inputInt("B: ");
                if (B < 0) { Instructions.info("B is lower then zero"); goto againB; }
                try
                {
                    Instructions.info($"{A}%{B} = {WithoutMath_(A, B)}");
                }
                catch{
                    goto againTask;
                }
            }

            Action[] actions =
            {
                ()=>Task1(),
                ()=>Task2()
            };
            Instructions.WorkList(actions);
            Console.ReadLine();
        }
    }
}
