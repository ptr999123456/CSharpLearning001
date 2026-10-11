namespace ch04ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入密码：");
            int pwd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入加密密钥");
            int key = Convert.ToInt32(Console.ReadLine());
            int pwdkey = pwd ^ key;
            Console.WriteLine ("加密后的密码为"+pwdkey);
        }
    }
}
