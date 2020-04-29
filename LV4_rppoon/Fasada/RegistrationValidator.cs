using System;
using System.Collections.Generic;
using System.Text;

namespace LV4_rppoon.Fasada
{
    class RegistrationValidator : IRegistrationValidator
    {
        public EmailValidator mailValidator;
        public PasswordValidator passValidator;
        public RegistrationValidator()
        {
            mailValidator = new EmailValidator();
            passValidator = new PasswordValidator(8);
        }

        public bool IsUserEntryValid(UserEntry entry)
        {
            return mailValidator.IsValidAddress(entry.Email) && passValidator.IsValidPassword(entry.Password);
        }
    }
}
