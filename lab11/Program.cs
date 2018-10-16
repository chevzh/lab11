using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "January", "Fabruary", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December" };

            int stringCount = Convert.ToInt32(Console.ReadLine());

            var result = from m in months
                         where m.Count() == stringCount
                         select m;

            foreach(var res in result)
            {
                Console.WriteLine(res);
            }


            result = from m in months
                     where m.Contains("u")
                     where m.Length >= 4
                     orderby m
                     select m;


            Console.WriteLine("\n");
            Console.WriteLine("Месяцы, содержащие букву u с длинной не менее 4-х символов, отсортированные в алфавитном порядке");
            foreach (var res in result)
            {
                Console.WriteLine(res);
            }

            result = months.Select(m => m).Where(m => m.Contains("u") || m == "December");
            
            Console.WriteLine("\n");
            Console.WriteLine("Только летние и зимние месяцы");
            foreach (var res in result)
            {
                Console.WriteLine(res);
            }

            
            List<MyDate> list = new List<MyDate>() {new MyDate(06,04,1996), new MyDate(1,2,1023), new MyDate(10,12,2018),
                new MyDate(5,4,1023),new MyDate(1,6,1025), new MyDate(01,1,1996) };
            list.Sort();
            Dictionary<string, IEnumerable<MyDate>> dictToPrint = new Dictionary<string, IEnumerable<MyDate>>()
            {
                { "-----------Даты 1996 года-----------" , list.Select(d => d).Where(d => d.Year == 1996)},
                { "-----------Апрельские даты-----------", list.Select(d => d).Where(d => d.Month == 4) },
                { "-----------Даты с 1023 года по 1996-----------",list.Select(d => d).Where(d => d.Year <= 1996 && d.Year >= 1023) },
                { "-----------Самая большая дата-----------", list.Max().ToList() },
                { "-----------Первая дата из списка с 1м числом-----------",list.Select(d => d).Where(d => d.Day == 1).First().ToList() },
                { "-----------Даты, упорядоченные по возрастанию-----------",list}

            };

            Print(dictToPrint);

            void Print(Dictionary<string, IEnumerable<MyDate>> dictionary)
            {
                foreach (var el in dictionary)
                {
                    Console.WriteLine(el.Key);
                    foreach(var v in el.Value)
                    {
                        v.PrintDate();
                    }
                    Console.WriteLine("\n");
                }
            }
           
        }
    }
}
