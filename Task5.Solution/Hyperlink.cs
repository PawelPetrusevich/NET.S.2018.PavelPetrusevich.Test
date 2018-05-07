namespace Task5.Solution
{
    using Task5.Solution.Visitors;

    public class HyperLink : DocumentPart
    {
        public string Url { get; set; }

        public override string Accept(IVisitor visitor)
        {
            return visitor.VisitHyperLink(this);
        }
    }
}
