namespace ch03pr001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "";
            Console.Write(" 请输入密码：");
            password += Console.ReadLine();
            Console.Write(" 请输入密码：");
            password += "、" + Console.ReadLine();
            Console.Write(" 请输入密码：");
            password += "、" + Console.ReadLine();
            Console.Write(" 请输入密码：");
            password += "、" + Console.ReadLine();
            Console.Write(" 请输入密码：");
            password += "、" + Console.ReadLine();
            Console.Write(" 请输入密码：");
            password += "、" + Console.ReadLine();
            Console.Write("\n 您六次输入的密码分别是" + password);
            Console.ReadLine();
        }
    }
}
