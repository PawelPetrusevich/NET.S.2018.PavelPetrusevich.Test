// --------------------------------------------------------------------------------------------------------------------
// <copyright company="NET.S.2018.PavelPetrusevich.Test" file=" PassValidatorTest.cs">
//  Creator name: 
//  Solution: NET.S.2018.PavelPetrusevich.Test
//  Project: Task1.Tests    
// </copyright>
// <summary>
//  Filename: PassValidatorTest.cs
//  Created day: 04.05.2018    10:10
//  </summary> 
//  --------------------------------------------------------------------------------------------------------------------

namespace Task1.Solution.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class PassValidatorTest
    {
        [Test]
        public void PasswordValidator()
        {
            string password = "qwertyyyy";
            PasswordValidatorBuilder validator = new PasswordValidatorBuilder(password)
                .EmptyChecked()
                .MinLengthCheck()
                .MaxLengthCheck();
            PasswordCheckerService service = new PasswordCheckerService();
            Assert.IsTrue(service.VerifyPassword(password,validator).Item1);
        }
    }
}