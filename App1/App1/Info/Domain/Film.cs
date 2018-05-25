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
        private string _info;
        private string _billede;
        #endregion

        #region Constuctor
        public Film(string titel, string info, string billede)
        {
            _titel = titel;
            _info = info;
            _billede = billede;
        }
        #endregion

        #region Properties


        public string Titel
        {
            get { return _titel; }
        }

        public string Info
        {
            get { return _info; }
        }

        public string Billede
        {
            get { return _billede; }
        }
        #endregion
    }
}
