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
    using System.Linq;

    public sealed class PasswordValidatorBuilder
    {
        private readonly List<string> ErrorList = new List<string>();

        public string Password { get; }

        public PasswordValidatorBuilder(string password)
        {
            this.Password = password;
        }

        public PasswordValidatorBuilder EmptyChecked()
        {
            if (this.Password == string.Empty)
            {
                this.ErrorList.Add($"{this.Password} is empty ");
            }

            return this;
        }

        public PasswordValidatorBuilder MinLengthCheck()
        {
            if (this.Password.Length <= 7)
                this.ErrorList.Add( $"{this.Password} length too short");

            return this;
        }

        public PasswordValidatorBuilder MaxLengthCheck()
        {
            if (this.Password.Length >= 15)
            {
                this.ErrorList.Add($"{this.Password} length too long");
            }

            return this;
        }

        public PasswordValidatorBuilder LetterChek()
        {
            if (!this.Password.Any(char.IsLetter))
            {
                this.ErrorList.Add($"{this.Password} hasn't alphanumerical chars");
            }

            return this;
        }

        public PasswordValidatorBuilder DigitsCheck()
        {
            if (!this.Password.Any(char.IsNumber))
            {
                this.ErrorList.Add($"{this.Password} hasn't digits");
            }

            return this;
        }

        public Tuple<bool, List<string>> IsValid()
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