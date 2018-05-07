namespace Task5.Solution
{
    using Task5.Solution.Visitors;

    public abstract class DocumentPart
    {
        public string Text { get; set; }

        public abstract string Accept(IVisitor visitor);
    }
}
