using System.Globalization;

namespace ch05ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "梦想还是要有的，万一实现了呢！";
            string str2;
            str2 = str1.Insert(0,"马云说：");
            string str3 = str2.Insert(19, "你信吗");
            Console.WriteLine(str3);
            Console.ReadLine();

        }
    }
}
