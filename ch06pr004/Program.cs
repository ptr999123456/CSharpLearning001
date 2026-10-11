namespace ch06pr004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int inum = rnd .Next(1,200);
            int iguess = Convert.ToInt16(Console.ReadLine());
            while (iguess != -1 & iguess != inum)
            {
                if(iguess < inum)
                {
                    Console.WriteLine("您输入的数字过小");
                    iguess = Convert.ToInt16(Console.ReadLine());
                }
                else if(iguess > inum)
                {
                    Console.WriteLine("您输入的数字过大");
                    iguess = Convert.ToInt16(Console.ReadLine());
                }
            }
            if (iguess == inum)
            {
                Console.WriteLine("恭喜你回答正确");
            }
            else if (iguess == -1)
            {
                Console.WriteLine("退出游戏成功");
            }
            Console.WriteLine("游戏结束");
            Console.ReadLine();

        }
    }
}
