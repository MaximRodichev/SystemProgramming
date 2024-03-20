using System;
using Instructs;
using static Instructs.Instructions;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace Practice_4___14._02._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Task1()
            {
                infoWithStrikeLine("Task 1 with 2 Brevnos");
                double MaxSize = 0;
                int[] brevnoSizes = { 15, 14, 13, 14, 12, 6, 3 };
                List<Brevno> brevnos= new List<Brevno>() {};
                //do { brevnos.Add(new Brevno(inputInt($"Длина {brevnos.Count + 1} бревна: "))); }
                //while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                do { brevnos.Add(new Brevno(brevnoSizes[brevnos.Count])); } 
                while(brevnoSizes.Length != brevnos.Count);
                foreach(var brevno in brevnos) { info($"{brevno}"); }
                bool isOpen = true;
                double max = brevnos.Select(x=>x.L).Max();
                double check = max;
                double truth = 0.25;
                int count = 7;
                do
                {
                    int countHere = brevnos.Where(x=>x.L>=check).Count();
                    info($"countHere: {countHere}\tcheck: {check}\tmax: {max}\tcount: {count}");
                    if (countHere < count && isOpen) { max /= 2; check = 0; isOpen = false; }
                    else if (countHere > count) { check = (check + max) / 2; isOpen = true; }
                    ReadLine();
                }
                while (true);
            }
            while(true) { Task1(); }
            ReadLine();

        }
    }
}
