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
    /// Interaktionslogik für auszahlungsfenster.xaml
    /// </summary>
    public partial class auszahlungsfenster : Page
    {
        public auszahlungsfenster()
        {
            InitializeComponent();
        }

        private void BtnAuszahlung_Click(object sender, RoutedEventArgs e)
        {
            var handler = BankHandler.GetInstance();
            
            decimal betrag = decimal.Parse(tbAuszahlung.Text);
            handler.Auszahlung(betrag, "Auszahlung");
            

        }
    }
}
