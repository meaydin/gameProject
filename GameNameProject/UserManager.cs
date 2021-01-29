using System;
using System.Collections.Generic;
using System.Text;

namespace GameNameProject
{
    class UserManager : IUserService
    {
        IUserValidationService _userValidationService; //constructor

        public UserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(User user)
        {
            if(_userValidationService.Validate(user))
            {
                Console.WriteLine("Kayıt Oldu.");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız. Kayıt Başarısız.");
            }
            
        }

        public void Delete(User user)
        {
            Console.WriteLine("Kayıt Silindi.");
        }

        public void Uptade(User user)
        {
            Console.WriteLine("Kayıt Güncellendi.");
        }
    }
}
