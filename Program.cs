namespace Baalhyttebooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    Opgave1
             Boernegruppe b0 = new Boernegruppe() { ID="EM",Name= "Elvis" ,Aldergruppe="puslig", AntalDeltagere=205};
            Boernegruppe b1 = new Boernegruppe() { ID = "PS", Name = "PETER", Aldergruppe = "sun", AntalDeltagere = 204};
            Boernegruppe b2 = new Boernegruppe() { ID = "CPC", Name = "PAUL", Aldergruppe = "Moon", AntalDeltagere = 202 };
            Boernegruppe b3= new Boernegruppe() { ID = "PCC", Name = "Sam", Aldergruppe = "Star", AntalDeltagere = 201 };
            Boernegruppe b4 = new Boernegruppe() { ID = "EM", Name = "John", Aldergruppe = "earth", AntalDeltagere = 205};

            Console.WriteLine(b0.ID);
            Console.WriteLine(b1.Name);
            Console.WriteLine(b2.Aldergruppe);
            Console.WriteLine(b3.AntalDeltagere);

            DateTime tid1 = new DateTime(2003,07,07);
            DateTime tid2 = new DateTime(2004, 08, 07);
            DateTime tids3= new DateTime(2005, 09, 07);
            DateTime tid4 = new DateTime(2006, 10, 07);
            DateTime tid5 = new DateTime(2007, 11, 07);

            Reservation reservation1 = new Reservation() { ID=6,Tidspunk=tid1, boernegruppe= b3 /*new Boernegruppe() { ID = "EM", Name = "Elvis", Aldergruppe = "puslig", AntalDeltagere=20 }*/  };
            Reservation reservation2 = new Reservation() { ID = 7, Tidspunk = tid2, boernegruppe =b3 /*new Boernegruppe() { ID = "yp", Name = "Elvis", Aldergruppe = "puslig", AntalDeltagere = 20 }*/ };
            Reservation reservation3 = new Reservation() { ID = 8, Tidspunk = tids3, boernegruppe = b3 /*new Boernegruppe() { ID = "ss", Name = "Elvis", Aldergruppe = "puslig", AntalDeltagere = 20 }*/ };
            Reservation reservation4 = new Reservation() { ID = 9, Tidspunk = tid4, boernegruppe = b3/*new Boernegruppe() {  ID= "EM", Name = "Elvis", Aldergruppe = "puslig", AntalDeltagere = 20 }*/ };
            Reservation reservation5 = new Reservation() { ID = 10,Tidspunk = tid5, boernegruppe = b3 /*new Boernegruppe() { ID = "EM", Name = "Elvis", Aldergruppe = "puslig", AntalDeltagere = 20 } */};


            ReservationsListe reservationsListe = new ReservationsListe();

            reservationsListe.AddReservation( reservation1);
            reservationsListe.AddReservation(reservation2);
            reservationsListe.AddReservation(reservation3);
            reservationsListe.AddReservation(reservation4);
            reservationsListe.AddReservation(reservation5);


            reservationsListe.Print();

            Console.WriteLine("gggggggggggggggggg" );

            reservationsListe.RemoveReservation( reservation1 );
            reservationsListe.Print();

            reservationsListe.Antalreservationer(b3);

            Console.WriteLine("uuuuuuuuuuu");

            reservationsListe.Reservationledig(reservation3);
            Console.WriteLine("ccccccccccccccccc");
            reservationsListe.ReservationOk(reservation2 );

            //OPGAVE 9

            try
            {
                if (reservationsListe.ReservationOk(reservation1))
                {
                    Console.WriteLine("Reservation is ok");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("reservation is invalid");

            }
            
            {

            }
               
            

        }
    }
}