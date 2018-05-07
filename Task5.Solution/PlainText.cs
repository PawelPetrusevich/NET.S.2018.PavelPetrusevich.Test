namespace Task5.Solution
{
    using Task5.Solution.Visitors;

    public class PlainText : DocumentPart
    {
        public override string Accept(IVisitor visitor)
        {
            return visitor.VisitPlainText(this);
        }
    }
}
