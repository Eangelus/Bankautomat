using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankautomat.src
{
    public class Transaktionen
    {
        public decimal Menge { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }

        public Transaktionen(decimal menge, DateTime date, string note)
        {
            Menge = menge;
            Date = date;
            Note = note;
        }
        public string giveMeAll()
        {
            return Note + ": " + Menge.ToString()+ " Euro" + " Am: " + Date.ToString();
        }

    }
}
