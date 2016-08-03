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
    /// Логика взаимодействия для NukeStrikeCountDialog.xaml
    /// </summary>
    public partial class NukeStrikeCountDialog : UserControl, Dialog
    {
        public delegate void ReceiveOrder(Object sender, Order order);
        ReceiveOrder receiveOrder;
        List<int> args;

        public NukeStrikeCountDialog(ReceiveOrder receiveOrder, List<int> args )
        {
            this.receiveOrder = receiveOrder;
            this.args = args;
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            args.Add((int)integerUpDown.Value);
            receiveOrder(this, new Order((int)Ministers.MinDef, "strike", args));
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            receiveOrder(this, new Order((int)Ministers.NoOne));
        }
    }
}
