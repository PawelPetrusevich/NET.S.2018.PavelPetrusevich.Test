namespace Task5.Console
{
    using System.Collections.Generic;
    using System;
    using Task5;
    using Task5.Solution;
    using Task5.Solution.Visitors;

    class Program
    {
        static void Main(string[] args)
        {
            List<DocumentPart> parts = new List<DocumentPart>
                {
                    new PlainText { Text = "Some plain text" },
                    new HyperLink { Text = "google.com", Url = "https://www.google.by/" },
                    new BoldText { Text = "Some bold text" }
                };

            Document document = new Document(parts);

            Console.WriteLine(document.Convert(new HtmlVisitor()));

            Console.WriteLine(document.Convert(new PlainTextVisitor()));

            Console.WriteLine(document.Convert(new LatexVisitor()));

            Console.ReadKey();
        }
    }
}
