using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maloncher_v2.src {
    [Serializable]
    class InfoWindow {
        public string Titre { set; get; }
        public List<InfoJeux> Jeux { set; get; }

        public InfoWindow (string titre) 
        {
            Titre = titre;
            Jeux = new List<InfoJeux>();
        }

        public void addInfoJeu(InfoJeux iJeu ) {
            Jeux.Add( iJeu );
        }

        public void removeInfoJeu(InfoJeux iJeu ) {
            Jeux.Remove( iJeu );
        }

        public InfoJeux getInfoJeu(string iJeu) {
            return Jeux.Find( item => item.Label == iJeu );
        }
    }
}
