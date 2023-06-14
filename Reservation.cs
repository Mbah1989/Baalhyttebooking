using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    public class Reservation
    {
        public int ID { get; set; }

        public DateTime Tidspunk { get; set; }  

        public Boernegruppe boernegruppe { get; set; }

        public override string ToString()
        {
            return $" ID = " + ID + " Tidspunk " + Tidspunk + " beornegruppe " + boernegruppe;
        }
    }
}
