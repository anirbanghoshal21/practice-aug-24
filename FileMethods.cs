using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ReusableCodeLibrary
{
    public class FileMethods
    {
        public static void MakeFile()
        {
            string path = @"C:\\Users\\Public\\Anirban\\FilesHandling\firstfile.txt";
            File.Create(path);
        }
    }
}
