using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using App1.Annotations;
using App1.Info.Domain;

namespace App1.ViewModels.App
{
    class PaymentViewmodel : INotifyPropertyChanged
    {

        public PaymentViewmodel()
        {
            PaymentCatalog.Instance.CreateNewPayment();
        }

        public string Name
        {
            get { return PaymentCatalog.Instance.Payments[0].Adresse; }
            set
            {
                PaymentCatalog.Instance.Payments[0].Adresse = value;
                OnPropertyChanged();
            }
        }

        public string Adresse
        {
            get { return PaymentCatalog.Instance.Payments[0].EmailAdresse;}
            set
            {
                PaymentCatalog.Instance.Payments[0].
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
