using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据类型
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var str2 = Console.ReadLine();
            int a1 = int.Parse(str);
            //if (!(int.TryParse(str, out a1)))
            //{
            //    Console.WriteLine("解析失败");
 
            //}
            int a2 = int.Parse(str2);
            Console.WriteLine(a1 + a2);
            Console.Read();
        }
    }
}
