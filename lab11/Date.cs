using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    public partial class MyDate
    {
        private int day;
        private int year;
        private int month;
        private readonly int id;
        private const int someConst = 123;
        private static int objectCounter = 0;






        public int Id
        {
            get => id;
        }

        public  int SomeConst  { get => someConst;}

        
        public  int Day
        { get => day;
          set
            {
                if(value >0 && value <= 31)
                {
                    day = value;
                }
                else
                {
                    Console.WriteLine("Задайте день числом от 0 до 31");
                }
            }
        }

        public int Month
        { get => month;
          set
            { 
                if(value > 0 && value <= 12)
                {
                    month = value;
                }
                else
                {
                    Console.WriteLine("Задайте месяц в пределах 1-12");
                }
            }
        }

        public int Year
        {
            get => year;
            set
            {
                try{
                    year = value;
                }


                catch (FormatException)
                {
                    Console.WriteLine("Год введён неверно");
                }
               
            }
        }


        public MyDate(int day) // с параметрами по умолчанию
        {
            Day = day;
            Month = 04;
            Year = 1984;
            id = year * month / day;
            objectCounter++;
        }

        public MyDate(int day, int month, int year) // с параметрами
        {
            Day = day;
            Month = month;
            Year = year;
            id = year * month / day;
            objectCounter++;
        }

        //private MyDate(string value) 
        //{            
        //    Console.WriteLine("qq " + value);
        //}

        public MyDate() // без параметров
        {

            objectCounter++;
        }       

        //static MyDate() // статический конструктор
        //{
        //    Console.WriteLine("Йо собаки");
        //    MyDate date = new MyDate("lel");
        //}


       
    }
}
