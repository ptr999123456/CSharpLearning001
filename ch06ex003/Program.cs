namespace ch06ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个月份");
            int a = Convert.ToInt16(Console.ReadLine());
            string str1;
            switch (a)
            {
                case 12:
                case 1:
                case 2:
                    str1 = "dongtian";
                    break;
                case 3:
                case 4:
                case 5:
                    str1 = "chuntian";
                    break;
                case 6:
                case 7:
                case 8:
                    str1 = "xiatian";
                    break;
                case 9:
                case 10:
                case 11:
                    str1 = "qiutian";
                    break;
                default:
                    str1 = "nononno";
                    break;

                    

            }
            Console.WriteLine(str1);
            Console.ReadLine();
        }
    }
}
