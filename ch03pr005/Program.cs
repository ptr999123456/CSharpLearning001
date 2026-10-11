using System.Globalization;

namespace ch03pr005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您的家庭地址：");
            string home = Console.ReadLine();
            Console.WriteLine("请输入您的工作地点：");
            string company = Console.ReadLine();
            Console.WriteLine("您的家庭地址和工作地点为：{0}，{1}", home,company);
            Console.ReadLine();
        }
    }
}
