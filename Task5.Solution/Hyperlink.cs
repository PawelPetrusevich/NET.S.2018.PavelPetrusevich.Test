﻿namespace Task5.Solution
{
    public class Hyperlink : DocumentPart
    {
        public string Url { get; set; }

        public override string ToHtml() => "<a href=\"" + this.Url + "\">" + this.Text + "</a>";

        public override string ToPlainText() => this.Text + " [" + this.Url + "]";

        public override string ToLaTeX() => "\\href{" + this.Url + "}{" + this.Text + "}";
    }
}
