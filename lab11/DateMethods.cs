using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    public partial class MyDate : IComparable
    {

        private List<String> months = new List<String>() { "Января", "Февраля", "Марта", "Апреля", "Мая", "Июня",
            "Июля", "Августа", "Сентября", "Октября", "Ноября", "Декабря" };

        private string GetMonthName(int month) => months.ElementAt(month - 1);

        public void SetDate()
        {
            try
            {
                Console.WriteLine("Введите число");
                Day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите месяц");
                Month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите год");
                Year = Convert.ToInt32(Console.ReadLine());
            }

            catch (FormatException)
            {
                Console.WriteLine("Проверьте правильность данных и введите их снова");
                SetDate();
            }
        }

        public static int GetSum(ref int value, out int constant)
        {
            constant = someConst;

            return value + constant;
        }

        public static void GetClassInfo()
        {
            Console.WriteLine("Количество объектов класса : " + objectCounter);
            
        }


        public void PrintDate()
        {
            Console.WriteLine(Day.ToString() + ' ' + GetMonthName(Month) + ' ' + Year.ToString() + " года");
        }

        public void PrintShortDate()
        {
            Console.WriteLine(Day + "/" + Month + "/" + Year);
        }

        // переопределение методов

        public override int GetHashCode()
        {
            int hashcode = day.GetHashCode();
            hashcode = 31 * hashcode + month.GetHashCode();
            hashcode = 31 * hashcode + year.GetHashCode();

            return hashcode;
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            MyDate date = obj as MyDate;
            if (date as MyDate == null)
                return false;

            return GetHashCode() == obj.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            MyDate date = new MyDate();
            date = obj as MyDate;

            if(date != null)
            {
                if (this.Year.CompareTo(date.Year) == 0)
                {
                    if (this.Month.CompareTo(date.Month) == 0)
                    {
                        return this.Day.CompareTo(date.Day);
                    }
                    else
                    {
                        return this.Month.CompareTo(date.Month);
                    }
                }
                else
                {
                    return this.Year.CompareTo(date.Year);
                }
            }
            else
            {
                return -100000;
            }
           
        }

        public List<MyDate> ToList()
        {
            MyDate date = new MyDate();
            date = this as MyDate;

            if (date != null)
            {
                return new List<MyDate>() { date };
            }
            else throw new InvalidCastException("Невозможно преобразовать в MyDate");
        }
    }
}
