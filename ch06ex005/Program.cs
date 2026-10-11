namespace ch06ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myarraylist = new string[3] { "yuanshen", "shshssh", "hshsshssh" };
            int i = 0;
            do
            {
                Console.WriteLine(myarraylist[i]);
                i++;
            }while (i < myarraylist.Length);
            Console.ReadLine();
        }
    }
}
