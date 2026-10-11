namespace ch06ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入关卡：");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine(1);
            }
            else if (num == 2)
            {
                Console.WriteLine(2);
            }
            else if(num == 3)
            {
                Console.WriteLine(3);
            }
            else
            {
                Console.WriteLine("当前游戏只有三关");
            }
            Console.ReadLine();

        }
    }
}
