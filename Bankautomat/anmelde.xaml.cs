﻿using Bankautomat.src;
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
    /// Interaktionslogik für anmelde.xaml
    /// </summary>
    public partial class anmelde : Page
    {
        public anmelde()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var handler = BankHandler.GetInstance();
            string benutzer = TbBenutzer.Text;
            string pw = TbPw.Text;
            var a = handler.findeKonto(benutzer, pw);
            Console.WriteLine("printe aus der anmelde das gefundene Konto: " + a);
            //anmelde.
        
        }
    }
}
