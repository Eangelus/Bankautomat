using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankautomat.src
{
    class Bankkonto
    {

        private int bankKontoID { get; }
        public string kontoInhaber { get; set; }
        public string passwort { get; set; }
        public decimal kontoStand { get; set; }
        private DateTime erÖffnungsDatum = DateTime.Now;
        public List<Transaktionen> KontoBewegung = new List<Transaktionen>();

        private bool abbuchungMöglich(decimal kontostand)
        {
            if (kontostand <= 0)
            {
                return false;
            }
            else { return true; }
        }

        public decimal kontoEinzahlung(decimal einzahlungsBetrag, DateTime datum, string wo)
        {
            Transaktionen trans = new Transaktionen(einzahlungsBetrag, datum, wo);
            kontoStand = +einzahlungsBetrag;
            this.KontoBewegung.Add(trans);
            return kontoStand;
        }
        
        public decimal kontoAuszahlung(decimal abbuchungsBetrag, DateTime datum, string wo)
                {
                    if (abbuchungMöglich(kontoStand) == true)
                    {
                        if (kontoStand >= abbuchungsBetrag)
                        {
                            Transaktionen trans = new Transaktionen(abbuchungsBetrag, datum, wo);
                            kontoStand = kontoStand - abbuchungsBetrag;
                            //KontoBewegung.Add(abbuchungsBetrag, datum, wo);
                            return abbuchungsBetrag;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                
    }
            


    }
}