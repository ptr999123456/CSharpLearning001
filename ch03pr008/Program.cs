namespace ch03pr008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入支付金额：");
            double a = Convert .ToDouble(Console.ReadLine());
            Console.WriteLine("您的支付金额为"+a+"元");
            Console.WriteLine("支付时间为："+DateTime.Now);
        }
    }
}
