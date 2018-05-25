using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Appointments.AppointmentsProvider;
using Windows.Media.Audio;
using Windows.Security.Cryptography.Core;
using App1.Info.Base;

namespace App1.Info.Domain
{
    public class FilmCatalog
    {


        private List<Film> _films;
        #region Constructor

        public FilmCatalog()
        {
            _films = new List<Film>();

            _films.Add(new Film("Deadpool", 1.59, "Billede"));
            _films.Add(new Film("Solo star wars", 2.15, "Billede"));
            _films.Add(new Film("Sankt bernhard syndikatet", 1.40, "Billede"));
            _films.Add(new Film("Mit grønland", 1.34, "Billede"));

        }




        #endregion
    }
}
