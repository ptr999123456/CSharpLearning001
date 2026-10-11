namespace ch05pr009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = @"D:\学习资料\CSharp\练习.cs";

            string path = Path.GetDirectoryName(a);
            string fileName = Path.GetFileName(a);
            string extension = Path.GetExtension(a);

            Console.WriteLine("文件路径：" + path);
            Console.WriteLine("文件名：" + fileName);
            Console.WriteLine("扩展名：" + extension);

            Console.ReadLine();
        }
    }
}
