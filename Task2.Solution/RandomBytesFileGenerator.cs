using System;
using System.IO;

namespace Task_2
{
    using Task2.Solution;
    public class RandomBytesFileGenerator:FileGenerator
    {
        public RandomBytesFileGenerator(string workingDirectory, string fileExtension)
            : base(workingDirectory, fileExtension)
        {
        }

        protected override byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }
    }
}