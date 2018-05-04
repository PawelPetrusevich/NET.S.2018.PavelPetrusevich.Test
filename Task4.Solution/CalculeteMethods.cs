// --------------------------------------------------------------------------------------------------------------------
// <copyright company="NET.S.2018.PavelPetrusevich.Test" file=" CalculeteMethods.cs">
//  Creator name: 
//  Solution: NET.S.2018.PavelPetrusevich.Test
//  Project: Task4.Solution    
// </copyright>
// <summary>
//  Filename: CalculeteMethods.cs
//  Created day: 04.05.2018    9:12
//  </summary> 
//  --------------------------------------------------------------------------------------------------------------------

namespace Task4.Solution
{
    using System.Collections.Generic;
    using System.Linq;

    public class CalculeteMethods
    {
        public static double MeanMethods(List<double> values)
        {
            return values.Sum() / values.Count;
        }

        public static double MedianMethods(List<double> values)
        {
            var sortedValues = values.OrderBy(x => x).ToList();

            int n = sortedValues.Count;

            if (n % 2 == 1)
            {
                return sortedValues[(n - 1) / 2];
            }

            return (sortedValues[sortedValues.Count / 2 - 1] + sortedValues[n / 2]) / 2;
        }
    }
}