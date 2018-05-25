using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Appointments.AppointmentsProvider;
using Windows.Media.Audio;
using Windows.Security.Cryptography.Core;


namespace App1.Info.Domain
{
    public class FilmCatalog
    {


        private List<Film> _films;
        #region Constructor

        public FilmCatalog()
        {
            _films = new List<Film>();

            _films.Add(new Film("Deadpool", 1.59, "..\\Assets\\Deadpool2.jpg"));
            _films.Add(new Film("Solo star wars", 2.15, "..\\Assets\\SOlo starwars.jpg"));
            _films.Add(new Film("Sankt bernhard syndikatet", 1.40, "..\\Assets\\sankt-bernhard-syndikatet.jpg"));
            _films.Add(new Film("Mit grønland", 1.34, "..\\Assets\\mit-groenland-plakat.jpg"));

        }
        public List<Film> Films
        {
            get { return _films; }
        }



        #endregion
    }
}
