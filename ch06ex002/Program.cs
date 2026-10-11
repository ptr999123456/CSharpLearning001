using System.Runtime.CompilerServices;

namespace ch06ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要查询的东西：");
            string a = Console.ReadLine();
            {
                switch (a)
                {
                    case "原神":
                        Console.WriteLine("yuanshen");
                        break;
                    case "王者荣耀":
                        Console.WriteLine("wangzherongyao");
                        break;
                    case "无畏契约":
                        Console.WriteLine("wuweiqiyue");
                        break;
                    default:
                        Console.WriteLine("无");
                        break;

                }
            }
            Console.ReadLine();
        }
    }
}
