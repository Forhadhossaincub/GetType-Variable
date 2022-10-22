using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetType_Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            float f = 12.5F;
            string st = "C#";
            char c = 'A';
            decimal money = 15221.12M;
            long lgn =1546554L;

            Console.WriteLine(a.GetType());
            Console.WriteLine(f.GetType());
            Console.WriteLine(st.GetType());
            Console.WriteLine(c.GetType());
            Console.WriteLine(money.GetType());
            Console.WriteLine(lgn.GetType());
            
            Console.ReadKey();


        }
    }
}
