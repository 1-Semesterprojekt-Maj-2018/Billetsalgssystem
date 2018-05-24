using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace App1.Info.Domain
{
 public class Film
    {
        #region instance fields
        private string _titel;
        private double _længde;
        private string _billede;
        #endregion

        #region Constuctor
        public Film(string titel, double længde, string billede)
        {
            _titel = titel;
            _længde = længde;
            _billede = billede;
        }
        #endregion

        #region Properties
        public string Titel
        {
            get { return _titel; }
        }

        public double Længde
        {
            get { return _længde; }
        }

        public string Billede
        {
            get { return _billede; }
        }
        #endregion
    }
}
