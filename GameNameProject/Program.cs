using System;

namespace GameNameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new UserValidationManager()); //PARANTEZ İÇİN DOĞRULAMA SERVİSİMİZDİR. SERVİS DEĞİŞTİĞİNDE BURASI DEĞİŞTİRİLECEKTİR.
            Gamer gamer1 = new Gamer { Id = 1, GamerId = 1, BirthDay = "1993", FirstName = "MEHMET", IdentityNo = 12345, LastName = "AYDIN",NickName="ARCEMN" };
            Console.WriteLine("Kullanıcı Adı : "+gamer1.NickName+"("+gamer1.FirstName+" "+gamer1.LastName+")");
            userManager.Add(gamer1);
            userManager.Delete(gamer1);
            userManager.Uptade(gamer1);
            Console.WriteLine();
            Personel personel1 = new Personel { Id = 2, PersonelId = 1, Title="Mimar" ,BirthDay = "1994", FirstName = "EMİN", LastName = "HAKTAN", IdentityNo = 54321 };
            Console.WriteLine("Kullanıcı Adı : "+personel1.Title+" "+personel1.FirstName+" "+personel1.LastName);
            userManager.Add(personel1);
            userManager.Delete(personel1);
            userManager.Uptade(personel1);
            Console.WriteLine();

            Sale sale1 = new Sale { SaleID = 1, GameName = "Super Mario", Price = 14.99 };
            saleManager.Sell(sale1);

            Console.ReadLine();

        }
    }
}
