using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace min_max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи числа через пробел в строку и нажми Enter");
            string str = Console.ReadLine();
            string[] spl = str.Split(' ');
            int[] lst = new int[spl.Length];
            for (int i = 0; i < lst.Length; i++)
			{
			 lst[i] = Int32.Parse(spl[i]);
			}
            Console.WriteLine("Read {0} numbers", lst.Length);
            int min = lst.Min();
            int max = lst.Max();
            Console.WriteLine("Min value: {0}", min);
            Console.WriteLine("Max value: {0}", max);
            
           
        




            Console.ReadKey();
        }
    }
}
