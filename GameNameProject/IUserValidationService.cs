using System;
using System.Collections.Generic;
using System.Text;

namespace GameNameProject
{
    interface IUserValidationService
    {
        bool Validate(User user);
    }
}
