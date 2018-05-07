// --------------------------------------------------------------------------------------------------------------------
// <copyright company="NET.S.2018.PavelPetrusevich.Test" file=" IVisitor.cs">
//  Creator name: 
//  Solution: NET.S.2018.PavelPetrusevich.Test
//  Project: Task5.Solution    
// </copyright>
// <summary>
//  Filename: IVisitor.cs
//  Created day: 07.05.2018    22:30
//  </summary> 
//  --------------------------------------------------------------------------------------------------------------------

namespace Task5.Solution.Visitors
{
    public interface IVisitor
    {
        string VisitBoldText(BoldText boldText);

        string VisitHyperLink(HyperLink hyperLink);

        string VisitPlainText(PlainText plainText);
    }
}