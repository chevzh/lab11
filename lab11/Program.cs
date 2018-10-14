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


                               

            //Console.WriteLine("\n");
            //Console.WriteLine("Только летние и зимние месяцы");
            //foreach (var res in result)
            //{
            //    Console.WriteLine(res);
            //}

        }
    }
}
