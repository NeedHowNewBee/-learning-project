using System;

namespace class2练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入3位数，倒着输出三位
            Console.WriteLine("请输入三位正整数");
            string inputNum = Console.ReadLine();
            //C代表 change 方法一
            int inputNumC = Convert.ToInt32(inputNum);
            //int Num100 = inputNumC/100;
            //int Num10 = (inputNumC - Num100 * 100)/10;
            //int Num1 = inputNumC-Num100*100-Num10*10;
            //Console.WriteLine("{0}{1}{2}",Num1,Num10,Num100);
            //方法二
            int ge = inputNumC % 10;
            int shi = (inputNumC / 10) % 10;
            int bai = inputNumC / 100;
            Console.WriteLine("{0}{1}{2}", ge, shi, bai);
        }
    }
}
