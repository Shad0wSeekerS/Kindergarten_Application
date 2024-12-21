using System.Windows;
using System.Windows.Input;

namespace App_interface
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

        private void password_TextBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (password_TextBox.Password.Length > 0)
            {
                lockImg.Visibility = Visibility.Collapsed;
                textBlockPass.Visibility = Visibility.Collapsed;
            }
            else
            {
                lockImg.Visibility = Visibility.Visible;
                textBlockPass.Visibility = Visibility.Visible;
            }
            
        }

        private void enterBT_Click(object sender, RoutedEventArgs e)
        {
            GlavnoeMeny window = new GlavnoeMeny();
            window.Show();
        }
    }
}