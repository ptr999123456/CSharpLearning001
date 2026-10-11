namespace ch04pr001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "蚂蚁庄园";
            Console.WriteLine("今年的支付次数：");
            int a =Convert.ToInt32(Console.ReadLine());
            int b = a * 180;
            Console.WriteLine("一共可以产生"+b+"g鸡饲料：");
            Console.ReadLine();



        }
    }
}
