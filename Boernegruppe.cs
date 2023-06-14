using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    public  class Boernegruppe
    {
        public string ID { get; set; }

        public string Name { get; set; }
        //Opgave 12
        
        public string Aldergruppe { get; set; }

        public int AntalDeltagere { get; set; }

        public override string ToString()
        {
            return $" ID = " + ID + " Name = " + Name + " Aldergruppe = " + Aldergruppe + " AntalletAfpersonner = " + AntalDeltagere;
        }



    }
}
