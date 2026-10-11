using System.Text;

namespace ch05pr005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "对比string and builder";
            String str1 = "string";
            StringBuilder str2 = new StringBuilder("string");
            str1.Insert(0, "yuanshen");
            Console.WriteLine(str1.GetHashCode());
            str2.Insert(0, "yuanshen");
            Console.WriteLine(str2.GetHashCode());
            Console.ReadLine();
        }
    }
}
