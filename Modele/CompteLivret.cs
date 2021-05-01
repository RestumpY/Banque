using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banque
{
    [Serializable]
    class CompteLivret : Compte
    {
        double _taux;

        public double Taux
        {
            get { return _taux; }
            set { _taux = value; }
        }

        public CompteLivret(int n, Client c, double taux)
            : base(n, c)
        {
            this._taux = taux;
        }

        public override string Description
        {
            get { return base.Description + " taux : " + this._taux; }
        }


    }
}
