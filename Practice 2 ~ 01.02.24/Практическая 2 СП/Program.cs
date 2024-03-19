using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Практическая_первая;

namespace Практическая_2_СП
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1st
            // Input N: 50
            // Work:
            // mas = 1 2 3 4 5 6
            // Sum(mas) = 21
            // Chk(mas) = 1 * 6 = 6 
            // new mas = 3 4 5 6 7 8
            // Sum(mas) = 33
            // Chk(mas) = 3*8 = 24
            // mas = 2 3 4 5 6 7
            // Sum(mas) = 27
            // Chk(mas) = 7*2 = 14


            // 1 st example
            // mas = a a+1 a+2 a+3 a+4 a+5
            // a * (a+5) = a + a+1 + a+2 + a+3 + a+4 + a+5
            // a * (a+5) = a + a + a + a + a + a + 15
            // а^2 + 5a = 6a + 15 
            // a^2 = a + 15


            // 2 nd example
            // mas = a, (a+x), ((a+x)+y), (((a+x)+y)+z), ((((a+x)+y)+z)+u), ((((a+x)+y)+z)+u)+i  
            // Sum(mas) = 6a + 5x + 4y + 3z + 2u + i =>
            // 
            // => 
            // What is last number and first?
            // Last = a+x+y+z+u+i ; First = a ; =>
            // => a^2+ax+ay+az+au+ai = 6a + 5x + 4y + 3z + 2u + i =>
            // => a(a+x+y+z+u+i) = 

            bool MuchMore(int x, int oborot = 200000, double diametr = 80)
            {
                diametr = diametr / 100 / 1000;
                double diametrCooef = diametr * Math.PI;
                double TeoreticalPath = oborot * diametrCooef;
                Instructions.infoWithStrikeLine($"MuchMore Logical:\nTargerPath: {x}km,\nDiametr: {diametr}km,\nDiametrCooef: {diametrCooef}km,\nTeoreticalPath: {TeoreticalPath}km");
                if (TeoreticalPath < x) { return false; }
                return true;
            }

            Dictionary<string, int> Zoo(int Animals, int N, int G)
            {
                Dictionary<string, int> output = new Dictionary<string, int>();
                int AllVerbludys = N / 4;
                int Nerp = Animals - AllVerbludys;
                int[] Zoo_recursion(int All, int Gorbs, int h_2, int h_1)
                {
                    h_2 = (Gorbs - h_1) / 2;
                    if (All - h_2 - h_1 < 0 || Gorbs - h_1 < 0) { throw new Exception("Impossible: In Recursion. Gorbs."); }
                    if (All - h_2 - h_1 != 0) { return Zoo_recursion(All, Gorbs, h_2, h_1+1); }
                    return new int[]{ h_2, h_1};
                }
                // 2h + 1h = G  all
                try
                {
                    if (AllVerbludys > Animals) { throw new Exception("Impossible: Verblydus>Animals"); }
                    int[] res = Zoo_recursion(AllVerbludys, G, 0, 0);
                    int h2 = res[0];
                    int h1 = res[1];
                    output.Add("Animals: ", Animals);
                    output.Add("AllVerbludys: ", AllVerbludys);
                    output.Add("Nerp: ", Nerp);
                    output.Add("h2: ", h2);
                    output.Add("h1: ", h1);
                    return output;
                }
                catch(Exception a)
                {
                    Instructions.Error(a.Message);
                    return output;
                }
                
            }

            int GetCurrentHomes(int N, int Target = 4)
            {
                if (N < 0 || N > 100) { throw new Exception("N over 100 or near 0"); }
                int count = 0;
                for (int x = 0; x < N; x++)
                {
                    if (x % 10 == Target) { count++; }
                    if (x / 10 == Target) { count++; }
                }
                return count;
            }

            List<string> GetAllIncrease()
            {
                List<string> result = new List<string>();
                for(int x = 0; x < 100; x++)
                {
                    int a = 0;
                    int Summochka = 0;
                    for(int g = 0; g < x; g++) { Summochka += g; }
                    while (true)
                    {
                        if (a + Summochka == a*a) { result.Add($"Pri {x}: {a} + {Summochka} = {a*a}"); }
                        if (a + Summochka > a*a && (a+1) + Summochka < (a+1) * (a+1)) { a+=x; }
                        if (a > 100) { break; }
                        a++;
                    }
                }


                return result;
            }

            void Task1()
            {
                foreach(var item in GetAllIncrease()) { Instructions.info($"{item}:"); }
            }

            void Task3()
            {
                foreach(var item in Zoo(Instructions.inputInt("All Animals: "), Instructions.inputInt("All Nogi: "), Instructions.inputInt("All Gorbs: ")))
                {
                    Instructions.info($"{item.Key}{item.Value}");
                }
            }

            void Task2()
            {
                Instructions.info($"{MuchMore(Instructions.inputInt("Hello, how kilometes is your target? -- "))}");
            }

            void Task4()
            {
                try
                {
                    Instructions.info($"Count with 4: {GetCurrentHomes(Instructions.inputInt("type me N (<100): "))}");
                }
                catch(Exception a) {  Instructions.Error(a.Message); }
            }

            Instructions.WorkList(new Action[]
            { 
                () => Task1(),
                () => Task2(),
                () => Task3(),
                () => Task4()
            }
            );


            Console.ReadLine();
        }
    }
}
