using Bankautomat.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bankautomat
{
    /// <summary>
    /// Interaktionslogik für Bilanz.xaml
    /// </summary>
    public partial class Bilanz : Page
    {
        public Bilanz()
        {
            InitializeComponent();
            var handler = BankHandler.GetInstance();

            var liste = handler.GetAllTransaktionen();
            TbBilanz.Text = "Hier kommt die Transaktionen\n\n";
            // Adde alles inhalte der Transaktionsliste in die Box
            foreach (Transaktionen t in liste)
            {

                    TbBilanz.Text += t.giveMeAll() + "\n";
                
            }
            TbBilanz.Text +="\n" + "Kontostand: " + handler.GetKontostand();
        }
    }
}
