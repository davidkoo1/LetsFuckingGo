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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace appTutorial.Components
{
    /// <summary>
    /// Логика взаимодействия для UserListingItem.xaml
    /// </summary>
    public partial class UserListingItem : UserControl
    {
        public UserListingItem()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dropDown.IsOpen = false;
        }
    }
}
