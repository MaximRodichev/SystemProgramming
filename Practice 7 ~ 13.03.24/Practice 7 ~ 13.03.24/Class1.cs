using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_7___13._03._24
{
    internal class Class1
    {
        //Автомобили имеют следующие грузоподъемности, вместимости и тарифы:
        //Газель – 1,5 т, 12 куб.м и 15 руб./км; ЗИЛ – 4 т, 20 куб.м. и
        //15 руб./км; МАЗ – 10 т, 35 куб.м. и 20 руб./км;
        //Scania – 20 т, 60 куб.м. и 30 руб./км; Volvo – 30 т, 75 куб.м и 40 руб./км. 
    }
    class Auto{
        public double Gruz { get; set; }
        public double Vmest { get; set; }
        public double Tarif { get; set; }
        public string Name { get; set; }

        public Auto(double gruz, int vmest, int tarif, string name)
        {
            Name = name;
            Gruz = gruz;
            Vmest = vmest;
            Tarif = tarif;
        }

        public override string ToString(){
            return $"Грузоподъемность: {Gruz:f2}т.\r\nВместимость: {Vmest:f2}куб.м\r\nТариф: {Tarif:f2}руб./км";
        }
    }

    class Gazel : Auto
    {
        public Gazel() : base(1.5, 12, 15, "Газель")
        {
            
        }
    }
    class ZIL : Auto
    {
        public ZIL() : base(4, 20, 15, "ЗИЛ")
        {

        }
    }
    class MAZ : Auto
    {
        public MAZ() : base(10, 35, 20, "МАЗ")
        {

        }
    }
    class Scania : Auto
    {
        public Scania() : base(20, 60, 30, "Скания")
        {

        }
    }
    class Volvo : Auto
    {
        public Volvo() : base(30, 75, 40, "Вольво")
        {

        }
    }

}
