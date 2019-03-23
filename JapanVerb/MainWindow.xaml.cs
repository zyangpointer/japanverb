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

namespace JapanVerb
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Timers.Timer timer;
        JapanVerbs verbs = new JapanVerbs();

        public MainWindow()
        {
            InitializeComponent();

            timer = new System.Timers.Timer();
            timer.Interval = 3000;
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {

               JapVerb verb =   verbs.getNext();
                txtBlock.Text = verb.VerbMasuForm;


            }));
              
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void BtnPrev_Click(object sender, RoutedEventArgs e)
        {
            JapVerb verb = verbs.getPrev();
            txtBlock.Text = verb.VerbMasuForm;

            txtDictNameInput.Text = "";
            txtTeFormInput.Text = "";
            txtNayiFormInput.Text = "";
            txtTaFormInput.Text = "";

        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            JapVerb verb = verbs.getNext();
            txtBlock.Text = verb.VerbMasuForm;


            txtDictNameInput.Text = "";
            txtTeFormInput.Text = "";
            txtNayiFormInput.Text = "";
            txtTaFormInput.Text = "";
        }

        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {
            JapVerb verb = verbs.currentVerb();

            if ( txtDictNameInput != null && txtTeFormInput != null)
            {
                if (txtDictNameInput.Text != verb.VerbDictionaryName)
                {
                    txtDictNameInput.Foreground = Brushes.Red;
                }
                else
                {
                    txtDictNameInput.Foreground = Brushes.Green;
                }
            }
          
                if (txtTeFormInput.Text != verb.VerbTeform)
                {
                    txtTeFormInput.Foreground = Brushes.Red;
                }
                else
                {
                    txtTeFormInput.Foreground = Brushes.Green;
                }
        }
    }
}