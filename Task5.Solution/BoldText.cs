namespace Task5.Solution
{
    using Task5.Solution.Visitors;

    public class BoldText : DocumentPart
    {
        public override string Accept(IVisitor visitor)
        {
            return visitor.VisitBoldText(this);
        }
    }
}