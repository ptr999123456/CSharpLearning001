namespace ch04ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入用户名字：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string pwd = Console.ReadLine();
            Console.WriteLine(name=="原神"&&pwd=="12341234");
            Console.ReadLine();
        }
    }
}
