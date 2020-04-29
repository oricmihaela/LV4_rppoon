using System;
using System.Collections.Generic;
using System.Text;

namespace LV4_rppoon.Fasada
{
    interface IPasswordValidatorService
    {
        bool IsValidPassword(String Candidate);
    }
}
