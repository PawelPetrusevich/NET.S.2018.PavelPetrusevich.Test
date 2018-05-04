// --------------------------------------------------------------------------------------------------------------------
// <copyright company="NET.S.2018.PavelPetrusevich.Test" file=" FunctionsClass.cs">
//  Creator name: 
//  Solution: NET.S.2018.PavelPetrusevich.Test
//  Project: Test6.Solution    
// </copyright>
// <summary>
//  Filename: FunctionsClass.cs
//  Created day: 04.05.2018    10:26
//  </summary> 
//  --------------------------------------------------------------------------------------------------------------------

namespace Test6.Solution
{
    using System;
    using System.CodeDom;
    using System.Linq.Expressions;

    public class FunctionsClass<T> where T : IConvertible
    {
        public static T FirstSequenceFormula(T first, T second)
        {

            return Add(first, second);
        }

        public static T ThirdsSequenceFormula(T first, T second)
        {

            var result = Add(second, Divide(first, second));
            return result;
        }

        public static T SecondSequenceFormula(T first, T second)
        {
            // convert int->T ???
            var result = WithOut(MultiPlay(6, second), MultiPlay(8, first));
            return result;
        }

        private static T Add(T first, T second)
        {
            ParameterExpression paramA = Expression.Parameter(typeof(T), "first");
            ParameterExpression paramB = Expression.Parameter(typeof(T), "second");
            BinaryExpression body = Expression.Add(paramA, paramB);
            Func<T, T, T> add = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();

            return add(first, second);
        }

        private static T WithOut(T first, T second)
        {
            ParameterExpression paramA = Expression.Parameter(typeof(T), "first");
            ParameterExpression paramB = Expression.Parameter(typeof(T), "second");
            BinaryExpression body = Expression.Subtract(paramA, paramB);
            Func<T, T, T> withOut = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();

            return withOut(first, second);
        }

        private static T MultiPlay(T first, T second)
        {
            ParameterExpression paramA = Expression.Parameter(typeof(T), "first");
            ParameterExpression paramB = Expression.Parameter(typeof(T), "second");
            BinaryExpression body = Expression.Multiply(paramA, paramB);
            Func<T, T, T> multiply = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();

            return multiply(first, second);
        }

        private static T Divide(T first, T second)
        {
            ParameterExpression paramA = Expression.Parameter(typeof(T), "first");
            ParameterExpression paramB = Expression.Parameter(typeof(T), "second");
            BinaryExpression body = Expression.Divide(paramA, paramB);
            Func<T, T, T> divide = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();

            return divide(first, second);
        }
    }
}