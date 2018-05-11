// --------------------------------------------------------------------------------------------------------------------
// <copyright company="NET.S.2018.PavelPetrusevich.Test" file=" FirstSequence.cs">
//  Creator name: 
//  Solution: NET.S.2018.PavelPetrusevich.Test
//  Project: Test6.Solution    
// </copyright>
// <summary>
//  Filename: FirstSequence.cs
//  Created day: 04.05.2018    10:41
//  </summary> 
//  --------------------------------------------------------------------------------------------------------------------

namespace Test6.Solution
{
    using System;
    using System.Collections.Generic;

    public class SequenceCalculate<T>
    {
        List<T> result = new List<T>();

        public List<T> ResultCalculate(int count, T first, T second, Func<T, T, T> calcFunction)
        {
            this.result.Add(first);

            this.result.Add(second);

            count -= 2;

            while (count > 0)
            {
                var temp = this.Calculate(first, second, calcFunction);
                this.result.Add(temp);
                first = second;
                second = temp;
                count--;
            }

            return this.result;
        }

        private T Calculate(T first, T second, Func<T, T, T> calcFunc)
        {
            return calcFunc(first, second);
        }
    }
}