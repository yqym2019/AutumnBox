﻿using AutumnBox.GUI.Helper;
using AutumnBox.GUI.UI.Fp;
using AutumnBox.GUI.Windows;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace AutumnBox.GUI.UI.CstPanels
{
    /// <summary>
    /// AboutControl.xaml 的交互逻辑
    /// </summary>
    public partial class AboutPanel : FastPanelChild
    {
        public AboutPanel()
        {
            InitializeComponent();
            LabelVersion.Content = SystemHelper.CurrentVersion.ToString();
#if! DEBUG
             LabelVersion.Content += "-release";
#else
            LabelVersion.Content += "-debug";
#endif
            LabelCompiledDate.Content = SystemHelper.CompiledDate.ToString("MM-dd-yyyy");
        }
        private void TextBlockGoToOS_MouseDown(object sender, MouseButtonEventArgs e) =>
            Process.Start(App.Current.Resources["urlOpensource"].ToString());

        private void TextBlockDonate_MouseDown(object sender, MouseButtonEventArgs e) =>
             new FastPanel(((MainWindow)App.Current.MainWindow).GridMain, new DonatePanel()).Display();
    }
}
