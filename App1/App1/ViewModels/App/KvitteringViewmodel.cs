using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography.Certificates;
using App1.Annotations;
using App1.Info.Domain;

namespace App1.ViewModels.App
{
    class KvitteringViewmodel : INotifyPropertyChanged
    {
        public KvitteringViewmodel()
        {

        }

        public string KviiteringsText
        {
            get { return $"Du har købt billet til {KvitteringCatalog.Instance.Kvitterings[0].Film.Titel}"; }
        }



        public string ImageSource
        {
            get { return KvitteringCatalog.Instance.Kvitterings[0].Film.Billede; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
