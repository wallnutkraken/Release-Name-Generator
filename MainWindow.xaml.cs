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

namespace Release_Name_Generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void settings_Btn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            this.IsEnabled = false;
            Setting settings = new Setting();
            settings.ShowInTaskbar = false;
            settings.Owner = this;
            settings.Show();
        }

        private void generate_Btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                generator_Box.Text = NameGenerator.Generate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
