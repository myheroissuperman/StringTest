using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTest
{
    class Program
    {
        public void Strtext(string str)
        {
            str = "aaa";
        }

        static void Main(string[] args)
        {
            //字符串是一种特殊的字符串,每次赋值都是重新生成新的字符串.
            string str1 = "bbb";
            Program pg = new Program();
            pg.Strtext(str1);
            Console.WriteLine(str1);

            //反射
            //Activator.CreateInstance(Type.GetType(类名));

            StringBuilder sb = new StringBuilder();
            DateTime dt1 = DateTime.Now;
            for (int i = 0; i < 20000; i++)
            {
                sb.Append("aaaa");
            }
            Console.WriteLine((DateTime.Now - dt1).TotalMilliseconds);
            string str3 = "";
            DateTime dt = DateTime.Now;
            for (int i = 0; i < 20000; i++)
            {
                str3 += "aaaa";
            }
            Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
            Console.ReadLine();
            string str2 = sb.ToString();

        }
    }
}
