using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Info.Domain
{
    class KvitteringCatalog
    {
        private static KvitteringCatalog _instance;

        public static KvitteringCatalog Instance
        {
            get
            {
                _instance = _instance == null ? new KvitteringCatalog() : _instance;
                return _instance;
            }
        }

        private List<Kvittering> _kvitteringer;

        private KvitteringCatalog()
        {
            _kvitteringer = new List<Kvittering>();

        }
        public List<Kvittering> Payments
        {
            get { return _kvitteringer; }
        }

        public void CreateNewPayment()
        {
            _kvitteringer.Insert(0, new Kvittering(null,null,null));
        }

        public void Setmoviechoice(Film film)
        {
            _kvitteringer[0].Film = film;
        }

        public void Setpayment(Payment payment)
        {
            _kvitteringer[0].Payment = payment;
        }

        public void Createreservation(Reservation reservation)
        {
            _kvitteringer[0].Reservation = reservation;
        }
    }
}
