using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankautomat.src
{
    internal class Bankkonto
    {

        private int BankKontoID { get; }
        public string KontoInhaber;
        public string Passwort;
        public decimal KontoStand { get; set; }
        private DateTime erÖffnungsDatum = DateTime.Now;
        public List<Transaktionen> ListeTrans;

        public Bankkonto()
        {
            ListeTrans = new List<Transaktionen>(); 
        }





    }

}



