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
            /* Once the button to open the settings window is clicked, this window becomes */
            /* hidden and disabled (the disabled part may have been a little redundant. Oh well! */
            /* Then, a Setting window is created (which won't be shown in the task bar) and this window */
            /* is declared it's parent. This becomes important when we want to close the newly-created */
            /* Setting window. */
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
