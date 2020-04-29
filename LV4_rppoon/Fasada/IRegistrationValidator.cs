using System;
using System.Collections.Generic;
using System.Text;

namespace LV4_rppoon.Fasada
{
    interface IRegistrationValidator
    {
        bool IsUserEntryValid(UserEntry entry);
    }
}
