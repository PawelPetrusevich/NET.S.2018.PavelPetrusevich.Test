// --------------------------------------------------------------------------------------------------------------------
// <copyright company="NET.S.2018.PavelPetrusevich.Test" file=" PasswordValidatorBuilder.cs">
//  Creator name: 
//  Solution: NET.S.2018.PavelPetrusevich.Test
//  Project: Task1.Solution    
// </copyright>
// <summary>
//  Filename: PasswordValidatorBuilder.cs
//  Created day: 04.05.2018    9:41
//  </summary> 
//  --------------------------------------------------------------------------------------------------------------------

namespace Task1.Solution
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public sealed class PasswordValidatorBuilder
    {
        private readonly List<string> ErrorList = new List<string>();

        private readonly string password;

        public PasswordValidatorBuilder(string _password)
        {
            if (_password == null)
            {
                throw new ArgumentNullException(nameof(_password));
            }

            this.password = _password;
        }

        public PasswordValidatorBuilder EmptyChecked()
        {

            if (this.password == string.Empty)
            {
                this.ErrorList.Add($"{password} is empty ");
            }

            return this;
        }

        public PasswordValidatorBuilder MinLengthCheck()
        {
            if (password.Length <= 7)
                this.ErrorList.Add( $"{password} length too short");

            return this;
        }

        public PasswordValidatorBuilder MaxLengthCheck()
        {
            if (this.password.Length >= 15)
            {
                this.ErrorList.Add($"{password} length too long");
            }

            return this;
        }

        public PasswordValidatorBuilder LetterChek()
        {
            if (!password.Any(char.IsLetter))
            {
                this.ErrorList.Add($"{password} hasn't alphanumerical chars");
            }

            return this;
        }

        public PasswordValidatorBuilder DigitsCheck()
        {
            if (!password.Any(char.IsNumber))
            {
                this.ErrorList.Add( $"{password} hasn't digits");
            }

            return this;
        }

        public Tuple<bool, List<string>> BuildValidator()
        {
            if (this.ErrorList.Count > 0)
            {
                return Tuple.Create(false, this.ErrorList);
            }

            else
            {
                this.ErrorList.Add("All OK");
                return Tuple.Create(true, this.ErrorList);
            }
        }
    }
}