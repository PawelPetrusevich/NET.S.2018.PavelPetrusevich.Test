namespace Task5.Solution
{
    using Task5.Solution.Formats;
    public abstract class DocumentPart : IToHtml,IToLaText,IToPlainText
    {
        public string Text { get; set; }

        public abstract string ToHtml();

        public abstract string ToLaTeX();

        public abstract string ToPlainText();
    }
}
