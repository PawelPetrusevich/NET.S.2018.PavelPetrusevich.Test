using System;
using System.Linq;

namespace Task1
{
    using System.Text;

    using Task1.Solution;

    public class PasswordCheckerService
    {
        private SqlRepository repository = new SqlRepository();

        public Tuple<bool, string> VerifyPassword(string password, PasswordValidatorBuilder validator)
        {
            var passValidator = validator
                .BuildValidator();

            if (passValidator.Item1)
            {
                this.repository.Create(password);

                return Tuple.Create(true, "Password is Ok. User was created");
            }
            else
            {
                StringBuilder errors = new StringBuilder();

                foreach (var error in passValidator.Item2)
                {
                    errors.Append(error);
                }

                return Tuple.Create(false, errors.ToString());
            }
        }
    }
}
