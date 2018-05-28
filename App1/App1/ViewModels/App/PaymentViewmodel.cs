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
            get { return PaymentCatalog.Instance.Payments[0].Navn; }
            set
            {
                PaymentCatalog.Instance.Payments[0].Navn = value;
                OnPropertyChanged();
            }
        }

        public string NameAddress
        {
            get { return PaymentCatalog.Instance.Payments[0].Adresse;}
            set
            {
                PaymentCatalog.Instance.Payments[0].Adresse = value;
                OnPropertyChanged();
            }
        }
        public int NameZipCode
        {
            get { return PaymentCatalog.Instance.Payments[0].Postnummer; }
            set
            {
                PaymentCatalog.Instance.Payments[0].Postnummer = value;
                OnPropertyChanged();
            }
        }

        public string NameEmail
        {
            get { return PaymentCatalog.Instance.Payments[0].EmailAdresse; }
            set
            {
                PaymentCatalog.Instance.Payments[0].EmailAdresse = value;
                OnPropertyChanged();
            }
        }

        public int NamePhoneNumber
        {
            get { return PaymentCatalog.Instance.Payments[0].Telefonnummer; }
            set
            {
                PaymentCatalog.Instance.Payments[0].Telefonnummer = value;
                OnPropertyChanged();
            }
        }
        public int NameCardNumber
        {
            get { return PaymentCatalog.Instance.Payments[0].Kortnummer; }
            set
            {
                PaymentCatalog.Instance.Payments[0].Kortnummer = value;
                OnPropertyChanged();
            }
        }
        public int NameCardExpire
        {
            get { return PaymentCatalog.Instance.Payments[0].kortUdløb; }
            set
            {
                PaymentCatalog.Instance.Payments[0].kortUdløb = value;
                OnPropertyChanged();
            }
        }
        public int NameCvv
        {
            get { return PaymentCatalog.Instance.Payments[0].Cvv; }
            set
            {
                PaymentCatalog.Instance.Payments[0].Cvv = value;
                OnPropertyChanged();
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
