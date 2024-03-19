using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Instructs.Instructions;
using static System.Console;
using static Functions.Practic1;
using System.Security.Cryptography.X509Certificates;

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
                List<int> digits = GetListofDigits(a);
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

            void Task2()
            {
                foreach (var item in GetListofDigits(123)) { Write(item); } 
            }

            Action[] actions =
            {
                ()=>Task1(),
                ()=>Task2()
            };
            WorkList(actions);
            ReadLine();

        }
    }
}
