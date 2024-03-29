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
    /// Interaktionslogik für einzahlungsfenster.xaml
    /// </summary>
    public partial class Einzahlungsfenster : Page
    {
        public static decimal betrag;
        public Einzahlungsfenster()
        {
            InitializeComponent();
        }

        private void btnEinzahlung_Click(object sender, RoutedEventArgs e)
        {
            betrag = decimal.Parse(tbEinzahlung.Text);
            BankHandler handler = BankHandler.GetInstance();
            handler.KontoEinzahlung(betrag, "Einzahlung");
        }

    }
}
