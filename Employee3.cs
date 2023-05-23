using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyakhov_lab7
{
    internal class Employee3 : Employee2
    {
        public int Hours { get; set; }

        public override string ToString()
        {
            return "Фамилия и инициалы: " + Surname + " " + Name[0] + "." + " " + "Возраст: " + Age(B_day) + " " + "Пол: " + Sex;
        }
        public override void Output()
        {
            Console.WriteLine("Фамилия и инициалы рабочего: {0} {1}.", Surname, Name[0]);
            Console.WriteLine("Возраст: {0}", Age(B_day));
            Console.WriteLine("Пол: {0}", Sex);
            Console.WriteLine("ЗП с учетом премии: {0}", fee_with_prize());
            Console.WriteLine("ЗП на руки: {0}", raschet());
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Введите почасовую оплату:");
            Fee = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите кол-во отработанных часов:");
            Hours = Convert.ToInt32(Console.ReadLine());

        }

        public override double fee_with_prize()
        {
            double feewithprize = (Fee*Hours) + (Fee*Hours * Prize_percent / 100);
            return feewithprize;
        }

    }
}
