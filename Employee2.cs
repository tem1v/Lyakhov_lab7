using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyakhov_lab7
{
    internal class Employee2 : Person
    {
        public virtual double Fee { get; set; }
        public double Prize_percent { get; set; }

        public override string ToString()
        {
            return "Фамилия и инициалы: " + Surname + " " + Name[0] + "." + " " + "Возраст: " + Age(B_day) + " " + "Пол: " + Sex;
        }
        public override void  Output()
        {
            Console.WriteLine("Фамилия и инициалы рабочего: {0} {1}.", Surname, Name[0]);
            Console.WriteLine("Возраст: {0}", Age(B_day));
            Console.WriteLine("Пол: {0}", Sex);
            Console.WriteLine("ЗП с учетом премии: {0}", fee_with_prize());
            Console.WriteLine("ЗП на руки: {0}", raschet());
        }
        public override void Input()
        {
            Console.WriteLine("Введите данные рабочего");
            base.Input();
            Console.Write("Оплата труда:");
            Fee = Convert.ToDouble(Console.ReadLine());
            Console.Write("Процент премии:");
            Prize_percent = Convert.ToDouble(Console.ReadLine());

        }
        public override int Age(int B_day)
        {
            return 2023 - B_day;
        }
        public virtual double fee_with_prize()
        {
            double feewithprize = Fee + (Fee * Prize_percent / 100);
            return feewithprize;
        }
        public virtual double duty()
        {
            double vichet = fee_with_prize() * 13 / 100;
            return vichet;
        }
        public virtual double raschet()
        {
            double itog = fee_with_prize() - duty();
            return itog;
        }
    }
}
