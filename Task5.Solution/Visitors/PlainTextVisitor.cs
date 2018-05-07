// --------------------------------------------------------------------------------------------------------------------
// <copyright company="NET.S.2018.PavelPetrusevich.Test" file=" PlainTextVisitor.cs">
//  Creator name: 
//  Solution: NET.S.2018.PavelPetrusevich.Test
//  Project: Task5.Solution    
// </copyright>
// <summary>
//  Filename: PlainTextVisitor.cs
//  Created day: 07.05.2018    22:49
//  </summary> 
//  --------------------------------------------------------------------------------------------------------------------

namespace Task5.Solution.Visitors
{
    public class PlainTextVisitor : IVisitor
    {
        public string VisitBoldText(BoldText boldText)
        {
            return "**" + boldText.Text + "**";
        }

        public string VisitHyperLink(HyperLink hyperLink)
        {
            return hyperLink.Text + " [" + hyperLink.Url + "]";
        }

        public string VisitPlainText(PlainText plainText)
        {
            return plainText.Text;
        }
    }
}