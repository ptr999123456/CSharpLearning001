namespace ch05ex015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "机器学习及深度学习";
            char[] str = new char[100];
            str1.CopyTo(0, str, 0, 4);
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
