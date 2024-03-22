using System;
using Instructs;
using static Instructs.Instructions;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace Practice_4___14._02._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Task1()
            {
                const int count = 7;
                const double truth = 0.1;
                infoWithStrikeLine("Task 1 with 2 Brevnos");
                double MaxSize = 0;
                //int[] brevnoSizes = { 12,13,7,8,2,3 };
                int[] brevnoSizes = { 14, 12, 13, 14, 15, 6, 3 };
                //int[] brevnoSizes = { 9,3};

                List<Brevno> brevnos= new List<Brevno>() {};
                do { brevnos.Add(new Brevno(brevnoSizes[brevnos.Count])); } 
                while(brevnoSizes.Length != brevnos.Count);
                foreach(var brevno in brevnos) { info($"{brevno}"); }
                double max = brevnos.Select(x=>x.L).Max();
                double check = 0;
   
                do
                {
                    check = (check + max) / 2;
                    check = Math.Round(check, 2);
                    var countHere_ = brevnos.Select(x => (int)Math.Truncate(x.L / check));
                    foreach (var item in countHere_) { info($"{item}"); }
                    int countHere = countHere_.Sum();
                    info($"countHere: {countHere}\tcheck: {check}\tmax: {max}\tcount: {count}");
                    if (countHere < count) { max = check; check = 0; };
                    if (max - check < truth) { break;  }
                    Error($"countHere: {countHere}\tcheck: {check}\tmax: {max}\tcount: {count}");
                    //ReadLine();
                }
                while (true);
                info($"Answer: {Math.Round((check+max)/2,2)}", ConsoleColor.Blue);
                ReadLine();
            }
            
            void Task2()
            {
                Task2_Logic(new Random().Next(7, 1000));
                Task2_Logic(new Random().Next(7, 1000));
                Task2_Logic(new Random().Next(7, 1000));
                Task2_Logic(new Random().Next(7, 1000));

                Task2_Logic(inputInt("Take me N: "));
                Task2_Logic(inputInt("Take me N: "));

                void Task2_Logic(int N)
                {
                    int allCount = 0;
                    int AndreyCost = 3;int SergeyCost = 5;
                    int AndreyCount = 0; int SergeyCount = 0;
                    while(allCount < N)
                    {
                        if (SergeyCount - AndreyCount == 1) { AndreyCount++; }
                        else { SergeyCount++; }
                        allCount = AndreyCost * AndreyCount + SergeyCost * SergeyCount;
                    }
                    info($"With N: {N}\nAndrey paid {AndreyCost}rubles X {AndreyCount}\tAndrey paid {SergeyCost}rubles X {SergeyCount}");
                }
            }

            void Task3()
            {
                string GenerateString()
                {
                    string Empty = "1";
                    foreach (var X in Enumerable.Range(1, 3000)) { WriteLine(X); Empty = $"{Empty}{X * 10}"; }
                    return Empty;
                }
                info($"{GenerateString().Length}");
            }

            WorkList(new Action[]{
                ()=>Task1(),
                ()=>Task2(),
                ()=>Task3()
            });
            ReadLine();

        }
    }
}
