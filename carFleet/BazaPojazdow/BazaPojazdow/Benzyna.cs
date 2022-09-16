using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaPojazdow
{
    class Benzyna : Pojazd
    {
        public override string PodajMase()
        {
            if(typ == "Motocykle")
            {
                return masa.ToString() + " kg";
            }
            else if(typ == "Osobowe" || typ == "Elektryczne")
            {
                return masa.ToString() + " t";
            }
            else
            {
                return masa.ToString();
            }
        }
        public override string PodajPaliwo()
        {
            return "Benzyna";
        }
    }
}
