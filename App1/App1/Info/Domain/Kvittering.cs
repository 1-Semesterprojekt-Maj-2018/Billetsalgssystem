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

        private string _Film;
        private int _Reservation;
        private string _Payment;

        public Kvittering(string film, int reservation, string payment)
        {
            _Film = film;
            _Reservation = reservation;
            _Payment = payment;
        }

        public string Film
        {
            get { return _Film; }
        }

        public int Reservation
        {
            get { return _Reservation; }

        }

        public string Payment
        {
            get { return _Payment; }
        }
    }
}
