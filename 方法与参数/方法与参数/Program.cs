using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法与参数
{
    class Program
    {
        //static double average(List<int> nums)
        //{
        //    int sum = 0;
        //    foreach (int i in nums)
        //    {
        //        sum = sum + i;
        //    }
        //    return (double)sum / nums.Count;
        //}
        //泛型
        //static void swap<T>(ref T a,ref T b)
        //{
        //    T temp;
        //    temp = a;
        //    a = b;
        //    b = temp;

        //}

        ////累加案例
        //static int sum(params int[] nums)
        //{
        //    return nums.Sum();
        //}

        //递归斐波拉契序列
        //static long fib(int n)
        //{
        //    //一定要确定return
        //    if (n == 1 || n == 2) return 1;
        //    return fib(n - 1) + fib(n - 2);

        //}

        //递归统计文件和文件夹数
        static long FileOrDirCount(string path,bool onlyDir)
        {
            long count = 0;
            //统计file的个数
            try
            {
                if (!onlyDir)
                {
                    var files = Directory.GetFiles(path);
                    count += files.Length;
                }
                

                //统计directory的个数
                var dirs = Directory.GetDirectories(path);
                count += dirs.Length;
                //要递归求文件夹数
                foreach (var dir in dirs)
                {
                    count += FileOrDirCount(dir,true);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
            

            return count;
        }

       

        static void Main(string[] args)
        {
            //var list = new List<int>();
            //list.Add(3);
            //list.Add(2);
            //list.Add(3);
            //Console.WriteLine(average(list));
           
            
            //Console.WriteLine(list.Average());

            //string a = "123";
            //string b = "456";
            //swap<string>(ref a, ref b);
            //Console.WriteLine("a = {0},b={1}", a, b);

            //Console.WriteLine(sum(1,2,3,4,5,6));

            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine(fib(i));
            //}
            Console.WriteLine("开始计算");
            Console.WriteLine(FileOrDirCount("D:/",true));
            Console.Read();
        }
    }
}
