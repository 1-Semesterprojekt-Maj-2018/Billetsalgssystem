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
    class ReservationViewmodel : INotifyPropertyChanged
    {
        private ReservationCatalog _reservationCatalog;
        private int _noOfReservations;

        public ReservationViewmodel()
        {
            _noOfReservations = 1;
            _reservationCatalog = new ReservationCatalog();
            _reservationCatalog.CreateNewReservation();
        }

        public int NoOfReservations
        {
            get { return _noOfReservations; }
            set
            {
                _noOfReservations = value;
                _reservationCatalog.SetNoOfReservations(value);
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
