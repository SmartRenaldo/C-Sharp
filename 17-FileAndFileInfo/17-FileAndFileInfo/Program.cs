namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var targetPath = "C:\\Projects\\C#\\17-FileAndFileInfo\\copyTest.txt";
            var srcPath = "C:\\Projects\\C#\\17-FileAndFileInfo\\test.txt";
            File.Copy(srcPath, targetPath, true);

            if (File.Exists(targetPath))
            {
                Console.WriteLine("Target File exists!");
                var srcContent = File.ReadAllText(srcPath);
                Console.WriteLine(srcContent);
            }

            File.Delete(targetPath);

            var fileInfo = new FileInfo(srcPath);
            fileInfo.CopyTo(targetPath, true);
        }
    }
}