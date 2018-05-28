using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Pwm;
using App1.Annotations;
using App1.Info.Domain;

namespace App1.ViewModels.App
{
    class ReservationViewmodel : INotifyPropertyChanged
    {
        private int _noOfReservations;
        private DateTime _tidspunkt;

        public ReservationViewmodel()
        {
            _noOfReservations = 1;
            ReservationCatalog.Instance.CreateNewReservation();
            KvitteringCatalog.Instance.Setreservation(ReservationCatalog.Instance.Reservations[0]);
        }

        public int NoOfReservations
        {
            get { return _noOfReservations; }
            set
            {
                _noOfReservations = value;
                ReservationCatalog.Instance.SetNoOfReservations(value);
                OnPropertyChanged();
            }
        }

        public DateTime Tidspunkt
        {
            get { return _tidspunkt; }
            set
            {
                _tidspunkt = value;
                ReservationCatalog.Instance.SetTidspunkt(value);
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
