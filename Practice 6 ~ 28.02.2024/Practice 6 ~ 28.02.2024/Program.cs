using System;
using System.Collections.Generic;
using System.Globalization;
using static System.Console;
using static Instructs.Instructions;
using static Functions.Practic1;
using System.Linq;
using System.Collections;

namespace Practice_6___28._02._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Task1()
            {
                //30 = 2 * (5+6)
                //9 6 8 7 7 8 6 9
                int n = 0;
                int cur = 0;
                int sum = 30;
                List <int[]> approve = new List<int[]>();
                List<int> checkIt = new List<int>();
                while(cur < 9999)
                {
                    cur = n * 2 * 7 * 11;
                    List<int> list = GetListofDigits(cur);
                     if (list.Distinct().Count() == 2)
                    {
                        if(list.Sum() == 30)
                        {
                            infoWithStrikeLine($"{cur}");
                            info($"{cur}/2 = {cur/2}\t{cur}/7 = {cur/7}\t{cur}/11 = {cur/11}");
                            info($"{string.Join(" + ", list)} = {30}");
                        }
                    }
                    n++;
                }
            }

            void Task2(){

                List<int[]> ints= new List<int[]>();
                for (int i = 0; i < 6; i++)
                {
                    int[] localInts = new int[6];
                    for(int j = 0; j < 6; j++)
                    {
                        localInts[j] = (i + j) % 6 + 1;
                    }
                    ints.Add(localInts);
                }
                foreach(int[] i in ints)
                {
                    info($"{string.Join("\t", i)}");
                }
            }

            void Task3()
            {
                int[,] ints = new int[4,4];
                int n = ints.GetLength(0);
                for (int i = 0; i < ints.Length; i += n)
                {
                    
                    info("Linear:");
                    for (int j = 0; j < n; j++)
                    {
                        Error($"{i/4} | {j} => {i + j + 1}");
                        ints[i/n, j] = i+j + 1;
                    }
                    i += n;
                    info("Reverse:");
                    for (int j = n - 1; j >= 0; j--)
                    {
                        Error($"{i/4} | {j} => {i+(n-j)}");
                        ints[i / n, j] = i + (n-j);
                    }
                }
                
                for(int g = 0; g < n; g++)
                {
                    //for(int k = n-1; k >= 0 ; k--)
                    for (int k = 0; k < n; k++)
                    {
                        Write($"{ints[g,k]}\t");
                    }
                    Write("\n");
                }

            }

            WorkList(new Action[] { () => Task1(), ()=>Task2(), ()=>Task3() });
            ReadLine();




        }
    }
}
