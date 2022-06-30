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
using Bankautomat.src;

namespace Bankautomat
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UnterMainW.Content = new anmelde();
            
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            UnterMainW.Content = new Register();

        }

        private void BtnEinzahlung_Click(object sender, RoutedEventArgs e)
        {
            BankHandler handler = BankHandler.GetInstance();
            
            if (handler.PrüfenObAngemeldet())
            {
                UnterMainW.Content = new Einzahlungsfenster();
            }
            else
            {
                UnterMainW.Content = new BitteAnmeldenFenster();
            }
        }

        private void BtnAuszahlung_Click(object sender, RoutedEventArgs e)
        {
            BankHandler handler = BankHandler.GetInstance();

            if (handler.PrüfenObAngemeldet())
            {
                UnterMainW.Content = new auszahlungsfenster();
            }
            else
            {
                UnterMainW.Content = new BitteAnmeldenFenster();
            }

        }

        private void BtnAbmelden_Click(object sender, RoutedEventArgs e)
        {
            BankHandler handler = BankHandler.GetInstance();
            handler.Abmelden();
            UnterMainW.Content = new AbmeldungErfolgreich();
        }

        private void BtnBilanz_Click(object sender, RoutedEventArgs e)
        {
            UnterMainW.Content = new Bilanz();
        }
    }
}
