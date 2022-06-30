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
    /// Interaktionslogik für register.xaml
    /// </summary>
    public partial class Register : Page
    {
       
        public Register()
        {
            InitializeComponent();
            
        }

        public void RegErfolg()
        {
            var handler = BankHandler.GetInstance();
            handler.CreateKonto(tbBenutzer.Text, tbpw1.Text);
            Console.WriteLine("KontotErstellt");

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(tbBenutzer.Text != null)
            {
                if(tbpw1.Text == tbpw2.Text)
                {
                    RegErfolg();
                    
                }
                else
                {
                    MessageBox.Show("Ihr Passwort stimmt nicht überein!");
                }
            }
            else
            {
                MessageBox.Show("Geben Sie einen Benutzernamen/ Inhaber Ihres Kontos an!");
            }
            

        }
    }
}
