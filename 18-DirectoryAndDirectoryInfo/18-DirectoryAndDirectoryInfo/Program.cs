namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("C:\\Projects\\C#\\18-DirectoryAndDirectoryInfo\\testDir");
            var files = Directory.GetFiles("C:\\Projects\\C#\\18-DirectoryAndDirectoryInfo\\18-DirectoryAndDirectoryInfo\\obj");

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories("C:\\Projects\\C#\\18-DirectoryAndDirectoryInfo", "*.*", SearchOption.AllDirectories);

            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }
        }
    }
}