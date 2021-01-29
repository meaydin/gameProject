using System;
using System.Collections.Generic;
using System.Text;

namespace GameNameProject
{
    interface IUserService
    {
        void Add(User user);
        void Uptade(User user);
        void Delete(User user);
    }
}
