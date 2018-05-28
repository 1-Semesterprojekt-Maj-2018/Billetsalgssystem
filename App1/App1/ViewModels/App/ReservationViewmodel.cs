using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using App1.Annotations;

namespace App1.ViewModels.App
{
    class ReservationViewmodel : INotifyPropertyChanged

    private ReservationDataViewModel _selectedDato;

    
    {
        public DateTimeOffset DateForShow
        {
            get { return DateForShow; }
            set
            {
                 = value.Dato;
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
