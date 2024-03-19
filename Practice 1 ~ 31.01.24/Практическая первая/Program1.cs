 using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net.NetworkInformation;
using Instruct;

namespace Практическая_первая
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input: integer Number, output List of integeres

            //Example: Input:25 -- Output: 25 5 1
            List<int> FindAllDeleteres_OfNumber(int trye)
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
 
            //if in 5digit number have a same digits in number, output: 1
            //else output any digit
            List<int> GetListofDigits(int trye)
            {
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
            bool CheckerToSameDigits(int trye)
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
            void CheckerToSameDigits_IfFiveDigits(int trye)
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

            //first number + last number == average number
            // 10403 - True
            // return list of true numbers
            // input any number \ checker works with lenght of number
            List<int> Checker(int trye)
            {
                List<int> digits = new List<int>();
                int lnght = Convert.ToString(trye).Length;
                if (lnght % 2 == 0)
                {
                    Instructions.Error("Its lenght%2 number");
                    return digits;
                }
                else if (lnght != 1)
                {
                    int h = Convert.ToInt32(Math.Pow((double)10, (double)lnght - 1));
                    for (int number = h; number < h * 10; number++)
                    {
                        int last = number % 10;
                        int first = number / h;
                        int average = number;
                        average = average % (int)Math.Pow(10, lnght / 2 + 1);
                        average = average / (int)Math.Pow(10, lnght / 2);
                        if (last + first == average)
                        {
                            //Instructions.info($"{last}+{first}={average} in number: {number}");
                            digits.Add(number);
                        }
                    }
                }
                return digits;
            }

            //in 2digit numbers
            //check (digit(1)+digit(2))*2 = digit(1)*digit(2)
            // 13 = (1 + 3)*2 = || 8 != 1+3 ||
            List<int> FoundAll2digitsNumbers()
            {
                List<int> output = new List<int>();
                for(int i = 10; i <= 100; i++) 
                { 
                    int first = i / 10;
                    int last = i % 10;
                    if((last+first)*2 == last * first)
                    {
                        output.Add(i);
                    }
                }
                return output;
            }

            //a*x+b*y=c, where all numbers is positive or zero
            //i know a,b,c | need found x and y
            //limits: a<=10000, and b<=10000, and c<=10000
            // a = 9, b = 5, c = 45
            // 9x+5y=45
            List<string> Found_X_Y_from_abc(int a, int b, int c)
            {
                List<string> output = new List<string>();
                List<string> output2 = new List<string>();
                for(int x = 0; x <= c; x++)
                {
                    int y = (c - a*x);// /b
                    if (y % b == 0 && y >= 0)
                    {
                        y /= b;
                        output.Add($"x: {x}| y: {y}\n{a}*{x} + {b}*{y} = {c}\n");
                        output2.Add($"x: {x}| y: {y}");
                    }
                }
                return output;
            }
            string FounderAll()
            {
                int limit = 10;
                string output = "";
                for(int a = 0; a<=limit; a++)
                {
                    for (int b = 1; b <= limit; b++)
                    {
                        for (int c = 0; c <= limit; c++)
                        {
                            output = output + $"with a = {a} | b = {b} | c = {c}\n";
                            foreach(var item in Found_X_Y_from_abc(a, b, c))
                            {
                                output += item + "\n";
                            }
                        }
                    }
                }
                return output;
            }
            string FounderOne(int a,int b, int c)
            {
                string output = $"Works with a={a}, b={b}, c={c}\n";
                foreach(var item in Found_X_Y_from_abc(a,b,c))
                {
                    output += item + "\n";
                }
                return output;
            }

            // 123 - 321
            int Reverse(int trye)
            {   
                List<int> digits = GetListofDigits(trye);
                int output = 0;
                for(int x = 0; x < digits.Count; x++) {
                    output += digits[digits.Count-x-1] * (int)Math.Pow(10, x);
                }
                return output;
            }
            void LinearMinusReverse(int trye)
            {
                int Linear = trye;
                int Reversed = Reverse(trye);
                Instructions.info($"Linear: {Linear} | Reversed: {Reversed}\nOutput: {Linear}-{Reversed} = {Linear - Reversed}");
                //return Reversed - Linear;
            }

            void Task1()
            {
                int attemp = Instructions.inputInt("WriteNumber to Found Deleters: ");
                foreach (var item in FindAllDeleteres_OfNumber(attemp))
                {
                    WriteLine(item);
                }
            }
            void Task2()
            {
                CheckerToSameDigits_IfFiveDigits(453206);
                CheckerToSameDigits_IfFiveDigits(41527);
                CheckerToSameDigits_IfFiveDigits(40000);
                CheckerToSameDigits_IfFiveDigits(Instructions.inputInt("Write Number to Task2: "));
            }
            void Task3()
            {
                foreach (var item in Checker(999))
                    Instructions.info($"{item}");
            }
            void Task4()
            {
                Instructions.info("4th Task | All 2digit numbers with (digit(1)+digit(2))*2 = digit(1)*digit(2)");
                foreach(var item in FoundAll2digitsNumbers())
                {
                    string itym = Convert.ToString(item);
                    Instructions.info($"{item} => ({itym[0]}+{itym[1]})*2 == {itym[0]}*{itym[1]}");
                }
            }
            void Task5()
            {
                Instructions.info("5th Task work");
                string filePath = "solutions.txt";
                Instructions.info("Write in Solutions");
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(FounderAll());
                }
                filePath = "solutions2.txt";
                Instructions.info("Write in Solutions2");
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(FounderOne(1,1,3));
                    writer.WriteLine(FounderOne(2,3,9));
                }
            }
            void Task6(){
                Instructions.info("6th Task\nI Can reverse number and minus from base number");
                for (int i = 0; i < 3; i++)
                {
                    LinearMinusReverse(Instructions.inputInt("Write me a number: "));
                }
            }

            Action[] actions = new Action[]
            {
                () => Task1(),
                () => Task2(),
                () => Task3(),
                () => Task4(),
                () => Task5(),
                () => Task6()
            };
            Instructions.WorkList(actions);


            ReadLine();
        }
    }
}
