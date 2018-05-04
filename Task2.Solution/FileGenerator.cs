// --------------------------------------------------------------------------------------------------------------------
// <copyright company="NET.S.2018.PavelPetrusevich.Test" file=" FileGenerator.cs">
//  Creator name: 
//  Solution: NET.S.2018.PavelPetrusevich.Test
//  Project: Task2.Solution    
// </copyright>
// <summary>
//  Filename: FileGenerator.cs
//  Created day: 04.05.2018    8:43
//  </summary> 
//  --------------------------------------------------------------------------------------------------------------------

namespace Task2.Solution
{
    using System;
    using System.CodeDom;
    using System.IO;

    public abstract class FileGenerator
    {
        private readonly string workingDirectory;

        private readonly string fileExtension;
        public FileGenerator(string workingDirectory, string fileExtension)
        {
            this.workingDirectory = workingDirectory;
            this.fileExtension = fileExtension;
        }

        public void GenerateFiles(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = this.GenerateFileContent(contentLength);

                var generatedFileName = $"{Guid.NewGuid()}{this.fileExtension}";

                this.WriteBytesToFile(generatedFileName, generatedFileContent);
            }
        }

        protected abstract byte[] GenerateFileContent(int contentLength);

        private void WriteBytesToFile(string fileName, byte[] content)
        {
            if (!Directory.Exists(this.workingDirectory))
            {
                Directory.CreateDirectory(this.workingDirectory);
            }

            File.WriteAllBytes($"{this.workingDirectory}//{fileName}", content);
        }
    }
}