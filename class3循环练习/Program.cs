using System;

namespace class3循环练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("你是一位火箭开发工程师，现在请你写出火箭升空倒计时程序 \n 请输入要注射的燃料百分比(0-100)");
            int fuel =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("%");
            //确认宇航员是否准备发射
            string no= "n";
            string playerkeyboard;
            
            do
            {
                Console.WriteLine("宇航员你准备好了吗？(y\\n)");
                playerkeyboard = Console.ReadLine();
            }while(no==playerkeyboard);
            for (int i=10;i>=0;i--)
            {
                Console.WriteLine("火箭发射倒计时{0}",i);

            }
            if(fuel <= 50)
                {
                Console.WriteLine("很遗憾火箭发射失败，呜呜呜呜");

                 }
            while(fuel>50)
            {
                Console.WriteLine("握草火箭发射成功了！你真是厉害ヾ(✿ﾟ▽ﾟ)ノ");
                fuel = 0;
                break;
            }
            
            Console.ReadKey();
            //光标等待不退出程序
        }
    }
}
