using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Info.Domain
{
   public class ReservationCatalog
   {
       private List<Reservation> _reservations;

       public ReservationCatalog()
       {
           _reservations = new List<Reservation>();

       }

       public List<Reservation> Reservations
       {
           get { return _reservations; }
       }


       public void CreateNewReservation()
       {
           _reservations.Insert(0, new Reservation(DateTime.Now,0));
       }

       public void SetNoOfReservations(int noOfReservations)
       {
           _reservations[0].AntalPersoner = noOfReservations;
       }
   }


}
