using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace App1.Info.Domain
{
    public class Kvittering
    {

        private Film _Film;
        private Reservation _Reservation;
        private Payment _Payment;

        public Kvittering(Film film, Reservation reservation, Payment payment)
        {
            _Film = film;
            _Reservation = reservation;
            _Payment = payment;
        }

        public Film Film
        {
            get { return _Film; }
            set { _Film = value; }
        }

        public Reservation Reservation
        {
            get { return _Reservation; }
            set { _Reservation = value; }

        }

        public Payment Payment
        {
            get { return _Payment; }
            set { _Payment = value; }
        }
    }
}
