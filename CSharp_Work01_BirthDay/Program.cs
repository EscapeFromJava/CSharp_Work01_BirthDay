using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Work01_BirthDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день, месяц и год рождения: ");
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            DateTime birthDay = new DateTime(year, month, day);

            DateTime now = DateTime.Now;
            //DateTime birthDay = new DateTime(2022, 8, 29);
            TimeSpan timeInterval = birthDay.Subtract(now);

            Console.WriteLine("День рождения наступит через {0} дней {1} час. {2} мин. {3} сек.", timeInterval.Days, timeInterval.Hours, timeInterval.Minutes, timeInterval.Seconds);
            Console.ReadKey();
        }
    }
}
