﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fizzi.Applications.ChallongeVisualization.View
{
    /// <summary>
    /// Interaction logic for MatchDisplayView.xaml
    /// </summary>
    public partial class MatchDisplayView : UserControl
    {
        public MatchDisplayView()
        {
            InitializeComponent();
        }

        private void PlayerBorder_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var border = sender as Border;
            if (border == null) return;

            var solidBrush = border.Background as SolidColorBrush;
            if (solidBrush == null) return;

            if (solidBrush.Color == Colors.Red) border.Background = new SolidColorBrush(Colors.SlateBlue);
            else if (solidBrush.Color == Colors.SlateBlue) border.Background = new SolidColorBrush(Colors.Red);
        }
    }
}
