using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MegaDeskProject_1
{
    class DeskQuote
    {
        private Desk derp;
        private int rushDays;
        private string customerName;
        private DateTime quote_date;

        public float calcDeskPrice()
        {
            float basePrice = 200;
            int drawerPrice = 50;
            if (derp.surfaceArea() > 1000)
            {
                basePrice += derp.surfaceArea();
            }





            return 0;
        }
    }


}

