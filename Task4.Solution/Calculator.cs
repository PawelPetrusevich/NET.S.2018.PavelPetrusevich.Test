// --------------------------------------------------------------------------------------------------------------------
// <copyright company="NET.S.2018.PavelPetrusevich.Test" file=" Calculator.cs">
//  Creator name: 
//  Solution: NET.S.2018.PavelPetrusevich.Test
//  Project: Task4.Solution    
// </copyright>
// <summary>
//  Filename: Calculator.cs
//  Created day: 04.05.2018    9:10
//  </summary> 
//  --------------------------------------------------------------------------------------------------------------------

namespace Task4.Solution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Calculator
    {
        public double CalculateAverage(List<double> values, Func<List<double>, double> calcFunc)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return calcFunc(values);
        }
    }
}