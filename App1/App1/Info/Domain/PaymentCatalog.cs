using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Info.Domain
{
    class PaymentCatalog
    {
        private static PaymentCatalog _instance;

        public static PaymentCatalog Instance
        {
            get
            {
                _instance = _instance == null ? new PaymentCatalog() : _instance;
                return _instance;
            }
        }

        private List<Payment> _payments;

        private PaymentCatalog()
        {
            _payments = new List<Payment>();

        }
        public List<Reservation> Reservations
        {
            get { return _reservations; }
        }

        public void CreateNewReservation()
        {
            _reservations.Insert(0, new Reservation(DateTime.Now, 0));
        }

    }
}
