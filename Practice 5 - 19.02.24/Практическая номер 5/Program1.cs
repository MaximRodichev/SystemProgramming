using Instructs;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Functions
{
    public class Practic1
    {
        /// <summary>
        /// Возвращает все возможные делители числа
        /// </summary>
        public static List<int> FindAllDeleteres_OfNumber(int trye)
        {
            int targetDeleter = trye;
            List<int> Output = new List<int>();
            while (targetDeleter != 0)
            {
                if (trye % targetDeleter == 0)
                {
                    Output.Add(targetDeleter);
                    targetDeleter /= 2;
                }
                else
                {
                    targetDeleter--;
                }
            }
            return Output;
        }

        /// <summary>
        /// Преобразует 456 в List{4, 5, 6}
        /// </summary>
        /// <param name="trye">Принимает Число (int)</param>
        /// <returns>Возвращает List</returns>
        public static List<int> GetListofDigits(int trye)
        {
            trye = Reversed(trye);
            List<int> digits = new List<int>();
            int Deleter = 10;
            while (Deleter / 10 < trye)
            {
                int target = (trye % Deleter) / (Deleter / 10);
                digits.Add(target);
                //Instructions.info($"{trye}%{Deleter}:{target}");
                Deleter *= 10;
            }
            return digits;
        }
        private bool CheckerToSameDigits(int trye)
        {
            List<int> digits = GetListofDigits(trye);
            if (digits.Count() > digits.Distinct().Count())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void CheckerToSameDigits_IfFiveDigits(int trye)
        {
            if (Convert.ToString(trye).Length == 5)
            {
                if (CheckerToSameDigits(trye))
                {
                    WriteLine($"{trye}: Have same digits - 1");
                }
                else
                {
                    WriteLine($"{trye}: Haven't same digits");
                }
            }
            else
            {
                Instructions.Error("Lenght of number isn't 5 digit");
            }
        }


        /// <summary>
        /// Reverse a Number
        /// </summary>
        /// <return>Int</return>
        public static int Reversed(int trye)
        {
            List<int> digits = GetListofDigits(trye);
            int output = 0;
            for (int x = 0; x < digits.Count; x++)
            {
                output += digits[digits.Count - x - 1] * (int)Math.Pow(10, x);
            }
            return output;
        }
        void LinearMinusReverse(int trye)
        {
            int Linear = trye;
            int Reverse = Reversed(trye);
            Instructions.info($"Linear: {Linear} | Reversed: {Reverse}\nOutput: {Linear}-{Reverse} = {Linear - Reverse}");
            //return Reversed - Linear;
        }

        //void Task1()
        //{
        //    int attemp = Instructions.inputInt("WriteNumber to Found Deleters: ");
        //    foreach (var item in FindAllDeleteres_OfNumber(attemp))
        //    {
        //        WriteLine(item);
        //    }
        //}
        //void Task2()
        //{
        //    CheckerToSameDigits_IfFiveDigits(453206);
        //    CheckerToSameDigits_IfFiveDigits(41527);
        //    CheckerToSameDigits_IfFiveDigits(40000);
        //    CheckerToSameDigits_IfFiveDigits(Instructions.inputInt("Write Number to Task2: "));
        //}
        //void Task3()
        //{
        //    foreach (var item in Checker(999))
        //        Instructions.info($"{item}");
        //}
        //void Task4()
        //{
        //    Instructions.info("4th Task | All 2digit numbers with (digit(1)+digit(2))*2 = digit(1)*digit(2)");
        //    foreach(var item in FoundAll2digitsNumbers())
        //    {
        //        string itym = Convert.ToString(item);
        //        Instructions.info($"{item} => ({itym[0]}+{itym[1]})*2 == {itym[0]}*{itym[1]}");
        //    }
        //}
        //void Task5()
        //{
        //    Instructions.info("5th Task work");
        //    string filePath = "solutions.txt";
        //    Instructions.info("Write in Solutions");
        //    using (StreamWriter writer = new StreamWriter(filePath))
        //    {
        //        writer.WriteLine(FounderAll());
        //    }
        //    filePath = "solutions2.txt";
        //    Instructions.info("Write in Solutions2");
        //    using (StreamWriter writer = new StreamWriter(filePath))
        //    {
        //        writer.WriteLine(FounderOne(1,1,3));
        //        writer.WriteLine(FounderOne(2,3,9));
        //    }
        //}
        //void Task6(){
        //    Instructions.info("6th Task\nI Can reverse number and minus from base number");
        //    for (int i = 0; i < 3; i++)
        //    {
        //        LinearMinusReverse(Instructions.inputInt("Write me a number: "));
        //    }
        //}

        //Action[] actions = new Action[]
        //{
        //    () => Task1(),
        //    () => Task2(),
        //    () => Task3(),
        //    () => Task4(),
        //    () => Task5(),
        //    () => Task6()
        //};
        //Instructions.WorkList(actions);


        //ReadLine();
    }
}
