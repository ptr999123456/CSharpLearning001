namespace ch05ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            string strB = string.Format("{0:D}", dt);
            Console.WriteLine("{0:D}", dt);
            Console.ReadLine(); 
        }
    }
}
