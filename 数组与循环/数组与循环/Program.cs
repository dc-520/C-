using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组与循环
{
    class Program
    {
        
 

        static void change(string num, int  fz, int  fm)
        {
	        bool flag = false;
	        char ch;
	        for (int i = 0; i < num.Length; i++)
	        {
		        ch = num[i];
		        if (ch == '.')	flag = true;
		        else
		        {
			        fz = fz * 10 + ch - '0';			/*fz==分子，fm==分母*/
			        if (flag) fm *= 10;
		        }
	        }
	        for (int i = 2; i <= fz; i++)				/*以下为化简*/
	        {
		        if (fz%i == 0 && fm%i == 0)
		        {
			        fz /= i;
			        fm /= i;
			        i = 1;
		        }
	        }
	        //cout << fz << '/' << fm << endl;
            Console.WriteLine("{0}/{1}", fz, fm);
	    

        }

        static void Main(string[] args)
        {
            double[] a = new double[101];
            //斐波拉契数列
            //a[0] = 1;
            //a[1] = 1;
            //int i = 2;
            //while (i < 10)
            //{
            //    a[i] = a[i - 1] + a[i - 2];
            //    i++;
            //}

            //for (int k = 0; k < a.Length; k++)
            //{
            //    Console.WriteLine(a[k]);
            //}
            //foreach (long j in a)
            //{
            //    Console.WriteLine(j);
            //}
            //随机数数组
            //var r = new Random();
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = r.Next() % 10;
            //}
            //foreach (int j in a)
            //{
            //    Console.WriteLine(j);
            //}
            //数组求和
            //int sum = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    sum = sum + a[i];
            //}
            //Console.WriteLine("数组和为{0}", sum);
            //查找数组中最大的数字
            //int max = a[0];
            //for (int i = 1; i < a.Length; i++)
            //{
            //    if (a[i] > max) {
            //        max = a[i];
            //    }
            //}
            //Console.WriteLine("最大数为{0}", max);
            #region 解决一个数学问题
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i;
            }
            for (int j = 1; j<=99; j++)
            {
                sum = sum + (a[j] / a[j + 1]);
            }
            Console.WriteLine("结果为{0}", sum);
            //string fenshu = sum.ToString();
            double num = 94.812;
            string fenshu = num.ToString();
            int fz = 0;
            int fm = 1;

            change(fenshu,fz,fm );
            #endregion
        }
    }
}
