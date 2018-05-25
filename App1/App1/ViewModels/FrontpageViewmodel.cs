using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Info.Domain;

namespace App1.ViewModels
{
    class FrontpageViewmodel
    {
        private FilmCatalog _filmCatalog;

        public FrontpageViewmodel()
        {
            _filmCatalog = new FilmCatalog();
        }

        public FilmCatalog Filmliste
        {
            get { return _filmCatalog; }
        }

    }

}
