namespace ch04pr002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "出租车计价标准";
            Console.WriteLine("多少公里：");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("燃油费次数：");
            int b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("出租车总费用：");
            if (a <= 2)
            {
                Console.WriteLine(10+b * 3+"元");
            }
            else
            {
                Console.WriteLine((a-2)*2.6+10+b*3+"元");
            }
            Console.ReadLine();
        }
    }
}
