﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using App1.Annotations;
using App1.Info.Domain;

namespace App1.ViewModels
{
    class FrontpageViewmodel : INotifyPropertyChanged
    {
        private FilmCatalog _filmCatalog;
        private Film _selectedFilm;

        public FrontpageViewmodel()
        {
            _filmCatalog = new FilmCatalog();
            _selectedFilm = Filmliste.Films[0];
            KvitteringCatalog.Instance.CreateNewKvittering();
        }

        public FilmCatalog Filmliste
        {
            get { return _filmCatalog; }
        }

        public Film SelectedFilm
        {
            get { return _selectedFilm; }
            set
            {
                _selectedFilm = value;
                KvitteringCatalog.Instance.Kvitterings[0].Film = _selectedFilm;
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
