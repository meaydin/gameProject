using System;
using System.Collections.Generic;
using System.Text;

namespace GameNameProject
{
    class SaleManager : ISaleService
    {
        public void Return(Sale sale)
        {
            Console.WriteLine(sale.GameName + " kütüphaneden kaldırıldı.");
        }

        public void Sell(Sale sale)
        {
            Console.WriteLine(sale.GameName + " kütüphaneye eklendi.");
        }
    }
}
