namespace Task1.Solution
{
    using System;
    using System.Text;

    public class PasswordCheckerService
    {
        private readonly IRepository repository;

        public PasswordCheckerService(IRepository repository)
        {
            this.repository = repository;
        }

        public Tuple<bool, string> VerifyPassword(PasswordValidatorBuilder validator)
        {
            var passValidator = validator.IsValid();

            if (passValidator.Item1)
            {
                this.repository.Create(validator.Password);

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
