using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 运算符和分支结构
{
    class Program
    {
        static void Main(string[] args)
        {
            //const int a = 10 % 3;
            
            //Console.WriteLine(a);
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1: Console.WriteLine("数字1"); break;
                case 2: Console.WriteLine("数字2"); break;
                default: Console.WriteLine("错误数据类型"); break;

            }
            Console.Read();
        }
    }
}
