// --------------------------------------------------------------------------------------------------------------------
// <copyright company="NET.S.2018.PavelPetrusevich.Test" file=" HtmlVisitor.cs">
//  Creator name: 
//  Solution: NET.S.2018.PavelPetrusevich.Test
//  Project: Task5.Solution    
// </copyright>
// <summary>
//  Filename: HtmlVisitor.cs
//  Created day: 07.05.2018    22:46
//  </summary> 
//  --------------------------------------------------------------------------------------------------------------------

namespace Task5.Solution.Visitors
{
    public class HtmlVisitor : IVisitor
    {
        public string VisitBoldText(BoldText boldText)
        {
            return "<b>" + boldText.Text + "</b>";
        }

        public string VisitHyperLink(HyperLink hyperLink)
        {
            return "<a href=\"" + hyperLink.Url + "\">" + hyperLink.Text + "</a>";
        }

        public string VisitPlainText(PlainText plainText)
        {
            return plainText.Text;
        }
    }
}