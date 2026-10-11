namespace ch05ex012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "*^__^*";
            string str2 = str1.PadLeft(7, '(');
            string str3 = str2.PadRight(8, ')');
            Console.WriteLine("补充字符串之前："+str1);
            Console.WriteLine("补充字符串之后："+str3);
            Console.ReadLine();
        }
    }
}
