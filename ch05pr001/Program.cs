namespace ch05pr001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您的性别（M or F)");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("您的保险单信息：");
            Console.WriteLine("保险单号：20170829");
            Console.WriteLine("年龄：25");
            Console.WriteLine("保险额度：50000");
            Console.WriteLine("您的性别为"+gender);
            Console.ReadLine();
        }
    }
}
