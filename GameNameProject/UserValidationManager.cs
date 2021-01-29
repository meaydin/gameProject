using System;
using System.Collections.Generic;
using System.Text;

namespace GameNameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if (user.BirthDay == "1993" && user.FirstName == "MEHMET" && user.LastName=="AYDIN" && user.IdentityNo==12345)
            {
                return true;
            }
            if(user.BirthDay == "1994" && user.FirstName == "EMİN" && user.LastName == "HAKTAN" && user.IdentityNo == 54321)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
