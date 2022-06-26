using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankautomat.src
{
    internal class BankHandler
    {
        public createKonto()
        {

            bankkonto.kontoInhaber = tbBenutzer.Text;
            bankkonto.passwort = tbpw1.Text;
            MessageBox.Show("Ihre Konto wurde erstellt!");
            //MainWindow.AlleBankkonten.Add(bankkonto);
            
        }



    }
}
