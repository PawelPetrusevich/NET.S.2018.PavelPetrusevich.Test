using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Tests
{
    using Task2.Solution;

    using Task_2;

    public static class Program
    {
        public static void Main()
        {
            string workingDerictory = @"C:\Users\Администратор\Desktop\NET.S.2018.LastName.Test\Task2.Tests";
            string byteExtension = ".bytes";
            string txtExtension = ".txt";
            int filesCount = 2;
            int contentLength = 2000;
            FileGenerator byteFileGenerator = new RandomBytesFileGenerator(workingDerictory, byteExtension);
            FileGenerator txtFileGenerator = new RandomCharsFileGenerator(workingDerictory, txtExtension);

            byteFileGenerator.GenerateFiles(filesCount, contentLength);
            txtFileGenerator.GenerateFiles(filesCount, contentLength);
        }
    }
}
