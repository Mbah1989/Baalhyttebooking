using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    public class Reservationer
    {
        public int ID { get; set; }

        public Dictionary<int, Reservation> Reservation { get; set; }

        public Reservationer()

        {
            DateTime Tids = new DateTime(2005, 12, 15);
            DateTime Tids2 = new DateTime(2006, 12, 15);
            DateTime Tids3 = new DateTime(2007, 12, 15);
            Reservation= new Dictionary<int, Reservation>();

            Reservation.Add(1, new Reservation() { ID = 1, Tidspunk = Tids, boernegruppe = new Boernegruppe() { ID = "EM", Name = "Pony", Aldergruppe = "Amfi", AntalDeltagere = 40 } });
            Reservation.Add(2,new Reservation() { ID = 2, Tidspunk = Tids, boernegruppe = new Boernegruppe() { ID = "EM", Name = "Pony", Aldergruppe = "Amfi", AntalDeltagere = 40 } });
            Reservation.Add(3,new Reservation() { ID = 3, Tidspunk = Tids, boernegruppe = new Boernegruppe() { ID = "EM", Name = "Pony", Aldergruppe = "Amfi", AntalDeltagere = 40 } });
            Reservation.Add(4,new Reservation() { ID = 4, Tidspunk = Tids, boernegruppe = new Boernegruppe() { ID = "EM", Name = "Pony", Aldergruppe = "Amfi", AntalDeltagere = 40 } });




        }
        //Opgave 6

        public  Dictionary<int, Reservation> GetAllReservation() 
        {
            return Reservation;

          
        }

        public void AddReservation(Reservation reservation)
        {
            if(!Reservation.Keys.Contains(reservation.ID)) 
            {
                Reservation.Add(reservation.ID, reservation);   
            }
        }

        public Dictionary<int, Reservation> Print() 
        {
            foreach(var rev in GetAllReservation())
            { 
                Console.WriteLine(rev.ToString());
            }
            return Reservation;
        }


        

        public void RemoveReservation(Reservation reservation)
        {
            if(reservation!=null)
            { 
                Reservation.Remove(reservation.ID);
            }
        }

        //Opgave 7.1

        public int Antalreservationer(Boernegruppe bGruppe)
        {

          int amount = 0;

            foreach (Reservation r in Reservation.Values)
            {
                if (r.boernegruppe == bGruppe)
                {
                    amount++;

                }
            }
            Console.WriteLine(amount);
            return amount;
        }

        //Opgave 7.2
        public bool Reservationledig(Reservation reservation)

        {
           
            foreach (Reservation reserv in Reservation.Values ) 
            {
                if (reserv.ID == reservation.ID)
                {
                   
                    Console.WriteLine(" not available");
                    return false;

                }
                else
                {

                    Console.WriteLine("booking is available");

                }

            }
            return true;

        }

        //Opgave 7.3

        public bool ReservationTidspunktOk(Reservation reservation)
        {

            if (reservation.Tidspunk.Year != reservation.ID)
            {
                return false;
            }
            if (reservation.Tidspunk.DayOfWeek != DayOfWeek.Thursday)
            {
                return false;
            }
            int hour = reservation.Tidspunk.Hour;
            if (hour != 12 && hour != 14 && hour != 16 && hour != 18 && hour != 18 && hour != 20)
            {
                return false;
            }
            int minute = reservation.Tidspunk.Minute;
            int second = reservation.Tidspunk.Second;
            int millesekunder = reservation.Tidspunk.Millisecond;
            if (minute != 0 && second != 0 && millesekunder != 0)
            {
                return false;
            }
            return true;
        }
        //Ogave 8

        public bool ReservationOk(Reservation reservation)
        {

            if (reservation.boernegruppe == null)
            {
                return false;
            }


            if (Antalreservationer(reservation.boernegruppe) >= 2)
            {
                return false;
            }

            if (Reservationledig(reservation))
                {

                return false;
            }

            if (Reservationledig(reservation))
            {
                return false;




            }

                return true;
            
        }

        



    }

}

    

