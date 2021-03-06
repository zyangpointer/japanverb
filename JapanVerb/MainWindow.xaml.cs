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

        const int TotalSeconds = 30;

        private int counter = TotalSeconds;

        public MainWindow()
        {
            InitializeComponent();

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;

            JapVerb verb = verbs.currentVerb();
            expanderTxtMasu.Text = verb.VerbMasuForm;
            expanderTxtKanji.Text = verb.VerbKanji;
            expanderTxtMeaning.Text = verb.VerbMeaning;

            expanderMasu.IsExpanded = true;

        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                counter--;
                if(counter == 0)
                {
                    JapVerb verb = verbs.getNext();
                    expanderTxtMasu.Text = verb.VerbMasuForm;
                    expanderTxtKanji.Text = verb.VerbKanji;
                    expanderTxtMeaning.Text = verb.VerbMeaning;
                    counter = 40;
                    resetTextBoxs();
                }
                btnStart.Content = counter + "秒";
            }));
              
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();

            btnNext.IsEnabled = false;
            btnPrev.IsEnabled = false;
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            btnStart.Content = "开始";
            counter = TotalSeconds;

            btnNext.IsEnabled = true;
            btnPrev.IsEnabled = true;
        }

        private void BtnPrev_Click(object sender, RoutedEventArgs e)
        {
            JapVerb verb = verbs.getPrev();
            expanderTxtMasu.Text = verb.VerbMasuForm;
            expanderTxtKanji.Text = verb.VerbKanji;
            expanderTxtMeaning.Text = verb.VerbMeaning;
            resetTextBoxs();
        }

        private void resetTextBoxs()
        {
            txtDictNameInput.Text = "";
            txtTeFormInput.Text = "";
            txtNayiFormInput.Text = "";
            txtTaFormInput.Text = "";
            txtDictNameInput.Background = Brushes.White;
            txtTeFormInput.Background = Brushes.White;
            txtNayiFormInput.Background = Brushes.White;
            txtTaFormInput.Background = Brushes.White;


            txtDictNameInput.Foreground = Brushes.Black;
            txtTeFormInput.Foreground = Brushes.Black;
            txtNayiFormInput.Foreground = Brushes.Black;
            txtTaFormInput.Foreground = Brushes.Black;


        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            JapVerb verb = verbs.getNext();
            expanderTxtMasu.Text = verb.VerbMasuForm;
            expanderTxtKanji.Text = verb.VerbKanji;
            expanderTxtMeaning.Text = verb.VerbMeaning;
            resetTextBoxs();
        }

        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {
            JapVerb verb = verbs.currentVerb();

            if ( txtDictNameInput != null && txtTeFormInput != null)
            {
                if (txtDictNameInput.Text != verb.VerbDictionaryName)
                {
                    txtDictNameInput.Foreground = Brushes.White;
                    txtDictNameInput.Background  = Brushes.Red;
                }
                else
                {
                    txtDictNameInput.Foreground = Brushes.White;
                    txtDictNameInput.Background = Brushes.LightGreen;
                }
            }

            if (txtTeFormInput.Text != verb.VerbTeform)
            {
                txtTeFormInput.Foreground = Brushes.White;
                txtTeFormInput.Background = Brushes.Red;
            }

            else
            {
                txtTeFormInput.Foreground = Brushes.White;
                txtTeFormInput.Background = Brushes.LightGreen;
            }

            if (txtNayiFormInput.Text != verb.VerbNayiForm)
            {
                txtNayiFormInput.Foreground = Brushes.White;
                txtNayiFormInput.Background = Brushes.Red;
            }
            else
            {
                txtNayiFormInput.Foreground = Brushes.White;
                txtNayiFormInput.Background = Brushes.LightGreen;
            }

             if (txtTaFormInput.Text != verb.VerbTaForm)
            {
                txtTaFormInput.Foreground = Brushes.White;
                txtTaFormInput.Background = Brushes.Red;
            }

            else
            {
                txtTaFormInput.Foreground = Brushes.White;
                txtTaFormInput.Background = Brushes.LightGreen;
            }
        }

        private void BtnDeveloper_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void BtnDeveloper_Click_1(object sender, RoutedEventArgs e)
        {
            if (SnackbarTwo.IsActive == true)
                SnackbarTwo.IsActive = false;
            else
            {
                SnackbarTwo.IsActive = true;
            }
        }

        private void ToggleIconButton_Click(object sender, RoutedEventArgs e)
        {
            if (SnackbarTwo.IsActive == true)
            {
                SnackbarTwo.IsActive = false;
                toggleDirectionButton.IsChecked = false;
            }

            else
            {
                SnackbarTwo.IsActive = true;
                toggleDirectionButton.IsChecked = true;

            }
        }
    }
}
