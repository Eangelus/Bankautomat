using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankautomat.src
{
    public class Transaktionen
    {
        public decimal Menge { get; }
        public DateTime Date { get; }
        public string Note { get; }

        public Transaktionen(decimal menge, DateTime date, string note)
        {
            Menge = menge;
            Date = date;
            Note = note;
        }

    }
}
