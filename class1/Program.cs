using System;

namespace class1
{
    class Program
    {
        static void Main(string[] args)
        {
            String cr = "陈睿";
            String lihai = "厉害";
            Console.WriteLine("FUCK World!");
            System.Console.WriteLine("what is different between us");
            Console.WriteLine("这是{0}的程序，{0}是第一次写程序。他{1},{0}是最{1}的", cr, lihai);
            //创建角色
            int hp=100,exp = 0;
            byte level = 1;
            Console.WriteLine("角色姓名:{0} \n等级{1} \n血量{2} \n经验{3}",cr,level,hp,exp);
            //读取输入，自加练习
            Console.WriteLine("请输入第一次获得的经验值");
            string exp1 = Console.ReadLine();
            Console.WriteLine("请输入第二次获得的经验值(*╹▽╹*)");
            string exp2 = Console.ReadLine();

            int exp1c = Convert.ToInt32(exp1);
            int exp2c = Convert.ToInt32(exp2);
            exp2c = --exp2c;
            exp = exp1c + exp2c;
            Console.WriteLine("角色姓名:{0} \n等级{1} \n血量{2} \n经验{3}", cr, level, hp, exp);
            
            //注释: Ctrl + K → 选定需要注释的代码段 →Ctrl + C
            //取消注释: Ctrl + K → 选定需要取消注释的代码段 →Ctrl + U
        }
    }
}
