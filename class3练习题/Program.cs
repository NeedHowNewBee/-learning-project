using System;

namespace class3练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //求出1~1000之间的所有能被7整除的数，并计算和输出每5个的和
            int sum=0;
            int count = 1;
            for (int i=1;i<1000;i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine("{0}能被七整除",i);
                    sum += i;
                    count++;
                    if(count == 5)
                    {
                        Console.WriteLine("五个被七整除的总和为{0}", sum);
                        sum = 0;
                        count = 0;
                    }
                    
                }


            }

            Console.WriteLine("九九乘法表");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    int result = i * j;
                    Console.WriteLine("{0}x{1}={2}", i, j, result);
                }
                Console.WriteLine("\n=============");

            }
            //===============================================================
            //生成随机数，掷色子6次并打印
            for (int i = 0; i < 6; i++)
            {
                Random roll = new Random();
                int number=roll.Next(1, 6);
                Console.WriteLine(number);
            }
            //输入4位字符并判断是否全是数字
            Console.WriteLine("\n=============\n 请输入4位字符串");
            string playerinputstring4 = Console.ReadLine();
            char playerinputchar;
            //string teat = "wasd";
            //Console.WriteLine(teat[2]);
            for (int i = 0; i <= 3; i++)
            {

                if ('0' <= playerinputstring4[i] && playerinputstring4[i] <='9')
                    //在0到9范围内
                {
                    Console.WriteLine("你输入的字符串都属于0~9");
                    Console.WriteLine(playerinputstring4[i]);
                    
                }
                else
                {
                    Console.WriteLine("超出0~9");
                    break;//输入的字符串超出0~9
                }

            }

        }
    }
}
