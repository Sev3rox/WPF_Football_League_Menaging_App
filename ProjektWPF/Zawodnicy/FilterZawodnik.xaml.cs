﻿using System;
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

namespace ProjektWPF.Zawodnicy
{
    /// <summary>
    /// Interaction logic for FilterZawodnik.xaml
    /// </summary>
    public partial class FilterZawodnik : Window
    {
        public FilterZawodnik()
        {
            InitializeComponent();
        }

        private void Filtr(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}