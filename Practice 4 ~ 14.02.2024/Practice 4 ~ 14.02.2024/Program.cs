using System;
using Instructs;

namespace Practice_4___14._02._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Task1()
            {
                Brevno BrevnoPervoe = new Brevno(Instructions.inputInt("Длина первого бревна: "));
                Brevno BrevnoVtoroe = new Brevno(Instructions.inputInt("Длина второго бревна: "));
                double maxSize;
                double t = BrevnoVtoroe.L>BrevnoPervoe.L ? BrevnoVtoroe.L : BrevnoVtoroe.L;
                while(true)
                {
                    BrevnoVtoroe
                }
            }
        }
    }
}
