
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace File_System_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FilePath = "C:\\File1";
            string FileName = Path.GetFileName(FilePath);

            FileInfo FileInfo = new FileInfo(FilePath);

            Console.WriteLine(FileName);
            Console.WriteLine(FilePath);

            Console.WriteLine(FileInfo.FullName);
            Console.WriteLine(FileInfo.Length);
            Console.WriteLine(FileInfo.DirectoryName);
            Console.WriteLine(FileInfo.CreationTime);
            Console.WriteLine(FileInfo.Exists);



            Console.ReadKey();
        }
    }
}
