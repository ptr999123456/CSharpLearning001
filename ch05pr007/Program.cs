namespace ch05pr007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "先搞他五百个小目标";
            for (int i = a.Length-1;i>= 0;i--)
            {
                Console.Write(a[i]);
            }
        }
    }
}
