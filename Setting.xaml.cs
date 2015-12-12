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
using System.ComponentModel;

namespace Release_Name_Generator
{
    /// <summary>
    /// Interaction logic for Setting.xaml
    /// </summary>
    public partial class Setting : Window
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            /* Tries loading the files containing words (since we probably changed some settings here). */
            /* The try catch is important because these files may not always exist. */
            try
            {
                NameGenerator.LoadFiles();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            /* And after it is done with reading the files (or failing to do so), this window refers to it's */
            /* parent (called Owner, in this case) and basically restores it to it's normal state. */
            Owner.Show();
            Owner.IsEnabled = true;
            Owner.Focus();
        }

        /* These following methods are all just methods to set the settings in the static */
        /* Settings class (the name similarity may be confusing, hm). */
        private void all_Noun_Checked(object sender, RoutedEventArgs e)
        {
            Settings.NounSetting = NounLevel.All;
        }

        private void one_Syl_Checked(object sender, RoutedEventArgs e)
        {
            Settings.NounSetting = NounLevel.OneSyllable;
        }

        private void two_Syl_Checked(object sender, RoutedEventArgs e)
        {
            Settings.NounSetting = NounLevel.TwoSyllable;
        }

        private void three_Syl_Checked(object sender, RoutedEventArgs e)
        {
            Settings.NounSetting = NounLevel.ThreeSyllable;
        }

        private void four_Syl_Checked(object sender, RoutedEventArgs e)
        {
            Settings.NounSetting = NounLevel.FourSyllable;
        }

        private void all_adj_Checked(object sender, RoutedEventArgs e)
        {
            Settings.AdjSetting = AdjectiveLevel.All;
        }

        private void one_adj_Checked(object sender, RoutedEventArgs e)
        {
            Settings.AdjSetting = AdjectiveLevel.OneSyllable;
        }

        private void two_adj_Checked(object sender, RoutedEventArgs e)
        {
            Settings.AdjSetting = AdjectiveLevel.TwoSyllable;
        }

        private void three_adj_Checked(object sender, RoutedEventArgs e)
        {
            Settings.AdjSetting = AdjectiveLevel.ThreeSyllable;
        }

        private void four_adj_Checked(object sender, RoutedEventArgs e)
        {
            Settings.AdjSetting = AdjectiveLevel.FourSyllable;
        }

        private void return_Btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
