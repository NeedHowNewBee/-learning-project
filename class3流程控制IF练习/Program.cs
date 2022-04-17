using System;

namespace class3流程控制IF练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请从0-100输入你的幸运数字");
            //直接获取输入数据并转换成int
            int playerNumber = Convert.ToInt32( Console.ReadLine());
            if (playerNumber <= 59)
            {
                Console.WriteLine("差一点点啊");
            }
            else
            {
                if (playerNumber <= 79)
                { Console.WriteLine("中规中矩"); }
                else
                {
                    if (playerNumber <= 89)
                        Console.WriteLine("还挺优秀");
                    else
                    {
                        if (playerNumber <= 100)
                        { Console.WriteLine("!!!∑(ﾟДﾟノ)ノ你小子挺牛逼啊"); }
                    }

                }

                
            }
        }
    }
}
