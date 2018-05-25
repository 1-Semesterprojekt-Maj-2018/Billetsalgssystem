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

            _films.Add(new Film("Deadpool", "Længde: 156 min", "Image/Deadpool 2.jpg"));
            _films.Add(new Film("Solo star wars", "Længde: 215 min", "Image/SOlo starwars.jpg"));
            _films.Add(new Film("Sankt bernhard syndikatet", "Længde: 140 min", "Image/sankt-bernhard-syndikatet.jpg"));
            _films.Add(new Film("Mit grønland", "Længde: 134 min", "Image/mit-groenland-plakat.jpg"));
            _films.Add(new Film("Warcraft", "Længde: 142 min", "Image/Warcraft.jpg"));
            _films.Add(new Film("De blinkende lygter", "længde: 132 min", "Image/De blinkende lygter.jpg"));


        }
        public List<Film> Films
        {
            get { return _films; }
        }



        #endregion
    }
}
