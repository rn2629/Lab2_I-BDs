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
using Lab2.ViewModel;

namespace Lab2.View
{
    /// <summary>
    /// Logique d'interaction pour Sauvegarde.xaml
    /// </summary>
    public partial class Sauvegarde : Window
    {
        public Sauvegarde()
        {
            InitializeComponent();
            DataContext = new MenuViewModel();
        }
    }
}