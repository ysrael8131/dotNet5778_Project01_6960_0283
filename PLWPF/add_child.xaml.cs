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
using BE;
namespace PLWPF
{
    /// <summary>
    /// Interaction logic for add_child.xaml
    /// </summary>
    public partial class add_child : Window
    {
        BL.IBL bl;
        public add_child(Mother a=null)
        {
            InitializeComponent();
            bl = BL.FactoryBl.getBl();
            motherIDTextBox.Text = a.id.ToString();
            
                //motherIDComBox.ItemsSource = bl.getListMothers().ToArray()[0].id.ToString();
            

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new add_mother().Show();
        }
    }
}
