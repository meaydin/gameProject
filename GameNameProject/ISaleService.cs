using System;
using System.Collections.Generic;
using System.Text;

namespace GameNameProject
{
    interface ISaleService
    {
        void Sell(Sale sale);
        void Return(Sale sale);

    }
}
