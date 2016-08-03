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

namespace MGcomponentsWPF.Dialogs.Military
{
    /// <summary>
    /// Логика взаимодействия для NukeStrikeDialog.xaml
    /// </summary>
    public partial class RaidDialog : UserControl, Dialog
    {
        public delegate void ReceiveOrder(Object sender, Order order);
        ReceiveOrder receiveOrder;

        public RaidDialog(ReceiveOrder receiveOrder )
        {
            this.receiveOrder = receiveOrder;
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            receiveOrder(this, new Order((int)Ministers.MinDef, "raid", new List<int> { this.comboBox.SelectedIndex }));
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            receiveOrder(this, new Order((int)Ministers.NoOne));
        }
    }
}
