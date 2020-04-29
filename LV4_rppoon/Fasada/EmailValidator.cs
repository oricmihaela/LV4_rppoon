using System;
using System.Collections.Generic;
using System.Text;

namespace LV4_rppoon.Fasada
{
    class EmailValidator : IEmailValidatorService
    {
        public bool IsValidAddress(string candidate)
        {
            if (String.IsNullOrEmpty(candidate))
            {
                return false;
            }
            return ContainsMonkey(candidate) && EndsWithDomena(candidate);
        }
        private bool ContainsMonkey(String candidate)
        {
            return candidate.Contains('@');
        }
        private bool EndsWithDomena(string candidate)
        {
            return candidate.EndsWith(".com") || candidate.EndsWith(".hr");
        }
    }
}
