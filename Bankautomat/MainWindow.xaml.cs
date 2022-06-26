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
        //public List<Bankkonto> AlleBankkonten => new List<Bankkonto>();
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
            UnterMainW.Content = new register();
            //AlleBankkonten.Add(register.bankkonto);
            
        }

        private void BtnEinzahlung_Click(object sender, RoutedEventArgs e)
        {
            UnterMainW.Content = new einzahlungsfenster();
        }

        private void BtnAuszahlung_Click(object sender, RoutedEventArgs e)
        {
            UnterMainW.Content = new auszahlungsfenster();
        }

        private void BtnAbmelden_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
