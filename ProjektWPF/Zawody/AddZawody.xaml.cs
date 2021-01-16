﻿using ProjektWPF.Data;
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
using System.Windows.Shapes;

namespace ProjektWPF.Zawody
{
    /// <summary>
    /// Logika interakcji dla klasy AddZawody.xaml
    /// </summary>
    public partial class AddZawody : Window
    {
        public Zawodys addzaw;
        ZawodnikDbContext context;
        public AddZawody(ZawodnikDbContext context)
        {
            this.context = context;
            InitializeComponent();
            InitializeComponent();
            addzaw = new Zawodys();
            AddGrid.DataContext = addzaw;
        }
        private void Add(object sender, RoutedEventArgs e)
        {
            var valhou = Validation.GetErrors(Nazwa);
            var valdat = Validation.GetErrors(DataStart);
            var valsed = Validation.GetErrors(DataStop);
            var valpla = Validation.GetErrors(Rodzaj);

            if (valhou.Count == 0 && valdat.Count == 0 && valsed.Count == 0 && valpla.Count == 0)
            {
                context.Zawodys.Add(addzaw);
                context.SaveChanges();
                DialogResult = true;
                this.Close();
            }
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void NazwaVali(object sender, RoutedEventArgs e)
        {
            Nazwa.Foreground = new SolidColorBrush(Colors.Black); ;
            addzaw.nazwa = null;
            Nazwa.Text = null;
        }
        private void RodzajVali(object sender, RoutedEventArgs e)
        {
            Rodzaj.Foreground = new SolidColorBrush(Colors.Black); ;
            addzaw.rodzaj = null;
            Rodzaj.Text = null;
        }
        private void validationError(object sender, ValidationErrorEventArgs e)
        {

            if (e.Action == ValidationErrorEventAction.Added)
            {
                if (e.Error.ErrorContent.ToString() == "Nazwę trzeba podać")
                {
                    Nazwa.Foreground = new SolidColorBrush(Colors.Red);
                    Nazwa.Text = e.Error.ErrorContent.ToString();
                }

                if (e.Error.ErrorContent.ToString() == "Datę rozpoczęcia trzeba podać")
                {
                    DataStart.Foreground = new SolidColorBrush(Colors.Red);
                }

                if (e.Error.ErrorContent.ToString() == "Datę zakończenia trzeba podać")
                {
                    DataStop.Foreground = new SolidColorBrush(Colors.Red);
                }
                if (e.Error.ErrorContent.ToString() == "Rodzaj trzeba podać")
                {
                    Rodzaj.Foreground = new SolidColorBrush(Colors.Red);

                }
            }

        }
    }
}
