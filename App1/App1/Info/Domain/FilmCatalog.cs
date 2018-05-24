using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Appointments.AppointmentsProvider;
using App1.Info.Base;

namespace App1.Info.Domain
{
    public class FilmCatalog
    {
        #region Constructor

        static void Catalog()
        {
            Film film1 = new Film("Deadpool", 1.59, "Billede");
            Film film2 = new Film("SOLO star wars", 2.15, "Billede");
            Film film3 = new Film("Sankt bernhard syndikatet", 1.40, "Billede");
            Film film4 = new Film("Mit grønland", 1.34, "Billede");
        }




        #endregion
    }
}
