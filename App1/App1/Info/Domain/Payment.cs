using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Info.Domain
{
    class Payment
    {
        #region Instance fields

        private string _navn;
        private string _adresse;
        private int _postnummer;
        private string _emailAdresse;
        private int _telefonnummer;
        private int _kortnummer;
        private int _kortUdløb;
        private int _cvv;

        #endregion

        #region Constructor

        public Payment(string navn, string adresse, int postnummer, string emailAdresse, int telefonnummer, int kortnummer,
            int cardExpire, int cvv)
        {
            _navn = navn;
            _adresse = adresse;
            _postnummer = postnummer;
            _emailAdresse = emailAdresse;
            _telefonnummer = telefonnummer;
            _kortnummer = kortnummer;
            _kortUdløb = kortUdløb;
            _cvv = cvv;
        }

        #endregion

        #region Properties

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public int Postnummer
        {
            get { return _postnummer; }
            set { _postnummer = value; }
        }

        public string EmailAdresse
        {
            get { return _emailAdresse; }
            set { _emailAdresse = value; }
        }

        public int Telefonnummer
        {
            get { return _telefonnummer; }
            set { _telefonnummer = value; }
        }

        public int Kortnummer
        {
            get { return _kortnummer; }
            set { _kortnummer = value; }
        }

        public int kortUdløb
        {
            get { return _kortUdløb; }
            set { _kortUdløb = value; }
        }

        public int Cvv
        {
            get { return _cvv; }
            set { _cvv = value; }
        }

        #endregion
    }
}