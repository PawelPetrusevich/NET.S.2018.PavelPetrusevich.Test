// --------------------------------------------------------------------------------------------------------------------
// <copyright company="NET.S.2018.PavelPetrusevich.Test" file=" LatexVisitor.cs">
//  Creator name: 
//  Solution: NET.S.2018.PavelPetrusevich.Test
//  Project: Task5.Solution    
// </copyright>
// <summary>
//  Filename: LatexVisitor.cs
//  Created day: 07.05.2018    22:51
//  </summary> 
//  --------------------------------------------------------------------------------------------------------------------

namespace Task5.Solution.Visitors
{
    public class LatexVisitor : IVisitor
    {
        public string VisitBoldText(BoldText boldText)
        {
            return "\\textbf{" + boldText.Text + "}";
        }

        public string VisitHyperLink(HyperLink hyperLink)
        {
            return "\\href{" + hyperLink.Url + "}{" + hyperLink.Text + "}";
        }

        public string VisitPlainText(PlainText plainText)
        {
            return plainText.Text;
        }
    }
}