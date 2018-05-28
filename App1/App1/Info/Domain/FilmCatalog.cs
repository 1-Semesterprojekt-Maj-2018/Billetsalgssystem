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

            _films.Add(new Film("Deadpool", "Længde: 156 min", "Image/Deadpool 2.jpg", "Denne gang må den sværdsvingende anti-helt og vansirede mutant samle et hold af med-mutanter for sammen at beskytte en ung artsfælle med superkræfter mod den brutale og tidsrejsende Cable"));
            _films.Add(new Film("Solo star wars", "Længde: 215 min", "Image/SOlo starwars.jpg", "Fortællingen om den legendariske charmørs første eventyr, hvor han udvikler sig fra små hustler til stor-smugler og rodes ind i en farefuld forbryderverden, hvor hans charme og evner som pilot bliver sat på prøve samt stifter bekendskab med hans bedsteven "));
            _films.Add(new Film("Sankt bernhard syndikatet", "Længde: 140 min", "Image/sankt-bernhard-syndikatet.jpg", "Rasmus og Frederik møder hinanden til en reunion på deres gamle kostskole, Herlufsholm. Her får Frederik overtalt en lettere naiv Rasmus til at drage med ud på et forunderligt forretningseventyr. Sammen skal de i Kina starte en virksomhed, hvor de kan starte en hundeavl."));
            _films.Add(new Film("Mit grønland", "Længde: 134 min", "Image/mit-groenland-plakat.jpg", "En lærer i Danmark tager et nyt job i en lille afsides bygd, Tiniteqilaaq, og nu må han lære bygdens mennesker og ikke mindst deres skikke og traditioner at kende. Når først han gør det, vil et helt nyt eventyr og en helt ny verden åbne sig for danskeren."));
            _films.Add(new Film("Warcraft", "Længde: 142 min", "Image/Warcraft.jpg", "As an Orc horde invades the planet Azeroth using a magic portal, a few human heroes and dissenting Orcs must attempt to stop the true evil behind this war."));
            _films.Add(new Film("De blinkende lygter", "længde: 132 min", "Image/De blinkende lygter.jpg", "Four small-time gangsters from Copenhagen trick a gangster boss: they take over 4,000,000 kroner which they were supposed to bring him. Trying to escape to Barcelona they are forced to stop in the countryside, in an old, wrecked house, hiding there for several weeks. Slowly, one after another, they realize, that they would like to stay there, starting a new life, renovating the house and forming it into a restaurant. But they can't avoid being caught up by their past."));


        }
        public List<Film> Films
        {
            get { return _films; }
        }



        #endregion
    }
}
