﻿using MGcomponentsWPF.Dialogs;
using MGcomponentsWPF.Dialogs.Military;
using MGcomponentsWPF.Dialogs.Common;
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

namespace MGcomponentsWPF
{
    /// <summary>
    /// Логика взаимодействия для MilitaryPanel.xaml
    /// </summary>
    public partial class MilitaryPanel : UserControl, InPanel
    {
        Dialog currentDialog;

        public MilitaryPanel()
        {
            InitializeComponent();
            this.NukeStrikeButton.click += () => createDialog<NukeStrikeDialog>(new NukeStrikeDialog(receiveOrder));
            this.WarButton.click += () => createDialog<WarDialog>(new WarDialog(receiveOrder));
            this.DefendButton.click += () => createDialog<DefCountDialog>(new DefCountDialog(receiveOrder));
            this.RaidButton.click += () => createDialog<RaidDialog>(new RaidDialog(receiveOrder));
            this.NukeCancelButton.click += () => createDialog<CancelDialog>(new CancelDialog(receiveOrder));
            this.NukesButton.click += () => createDialog<NukesCountDialog>(new NukesCountDialog(receiveOrder));
            this.PRObutton.click += () => createDialog<PROcountDialog>(new PROcountDialog(receiveOrder));
            this.LVLupButton.click += () => createDialog<LvlUpDialog>(new LvlUpDialog(receiveOrder, (int)Ministers.MinDef));
            this.HelpButton.click += () => createDialog<HelpDialog>(new HelpDialog(receiveOrder, (int)Ministers.MinDef));
        }

        private void createDialog<T>(Dialog dialog) where T : UIElement
        {
            if (currentDialog == null)
            {
                currentDialog = dialog;
                canvas1.Children.Add((T)currentDialog);
                Canvas.SetLeft((T)currentDialog, 295);
                Canvas.SetTop((T)currentDialog, 68);
            }
        }

        public void receiveOrder(object sender, Order order)
        {
            canvas1.Children.Remove((UIElement)sender);
            currentDialog = null;     
        }
    }
}
