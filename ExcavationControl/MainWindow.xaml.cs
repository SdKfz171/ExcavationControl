﻿using ExcavationControl.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ExcavationControl
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Application.Current.MainWindow.WindowState = WindowState.Maximized;

            Application.Current.MainWindow.MinWidth = 300;

            Application.Current.MainWindow.MinHeight = 370;

            SettingPage settingPage = new SettingPage();

            MainFrame.Navigate(settingPage);
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Size oldSize = e.PreviousSize;

            Size newSize = e.NewSize;

            Debug.WriteLine("예전 크기 : " + oldSize);

            Debug.WriteLine("현재 크기 : " + newSize);
        }
    }
}
