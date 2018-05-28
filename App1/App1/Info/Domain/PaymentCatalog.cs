using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Info.Domain
{
    public class PaymentCatalog
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
        public List<Payment> Payments
        {
            get { return _payments; }
        }

        public void CreateNewPayment()
        {
            _payments.Insert(0, new Payment(("Udfyld dit fulde navn.."),("Udfyld din adresse.."), 0,("Udfyld din email adresse.."),0,0,0,0));
        }
    }
}
