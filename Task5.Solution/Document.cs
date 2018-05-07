namespace Task5.Solution
{
    using System;
    using System.Collections.Generic;

    using Task5.Solution.Visitors;

    public class Document
    {
        private List<DocumentPart> parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }

            this.parts = new List<DocumentPart>(parts);
        }

        public string Convert(IVisitor visitor)
        {
            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                output += $"{part.Accept(visitor)}\n";
            }

            return output;
        }
    }
}
