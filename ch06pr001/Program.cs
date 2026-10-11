namespace ch06pr001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您的分数111");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 0&&a<60)
            {
                Console.WriteLine("废物");
            }
            else if (a >= 60 && a <= 75)
            {
                Console.WriteLine("垃圾");

            }
            else if (a >75 && a <= 85)
            {
                Console.WriteLine("还行吧");
            }
            else if (a >85 && a <= 100)
            {
                Console.WriteLine("可以");
            }
            else
            {
                Console.WriteLine("乱写什么呢");

            }
            Console.ReadLine();
        }
    }
}
