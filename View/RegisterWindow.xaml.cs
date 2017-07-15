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
using System.Windows.Shapes;

namespace View
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void User_Name_GotFocus(object sender, RoutedEventArgs e)
        {
            userName_txt.BorderBrush = Brushes.LightBlue;
        }

        private void User_Name_LostFocus(object sender, RoutedEventArgs e)
        {
            userName_txt.BorderBrush = Brushes.LightGray;
        }

        private void Password_GotFocus(object sender, RoutedEventArgs e)
        {
            password_txt.BorderBrush = Brushes.LightBlue;
        }

        private void Password_LostFocus(object sender, RoutedEventArgs e)
        {
            password_txt.BorderBrush = Brushes.LightGray;
        }

        private void ConfirmPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            confirmPass_txt.BorderBrush = Brushes.LightBlue;
        }

        private void ConfirmPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            confirmPass_txt.BorderBrush = Brushes.LightGray;
        }

        private void TermsOfService_MouseEnter(object sender, MouseEventArgs e)
        {
            TermsOfService_txt.TextDecorations = TextDecorations.Underline;
        }

        private void TermsOfService_MouseLeave(object sender, MouseEventArgs e)
        {
            TermsOfService_txt.TextDecorations = null;
        }

        private void TermsOfService_OnClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void CancelBtn_OnClick(object sender, MouseButtonEventArgs e)
        {
            CancelBtn.Background = Brushes.Red;
        }

        private void CancelBtn_NonClick(object sender, MouseButtonEventArgs e)
        {
            CancelBtn.Background = Brushes.IndianRed;
        }

        private void RegisterBtn_OnClick(object sender, MouseButtonEventArgs e)
        {
            RegisterBtn.Background = Brushes.DeepSkyBlue;
        }

        private void RegisterBtn_NonClick(object sender, MouseButtonEventArgs e)
        {
            RegisterBtn.Background = Brushes.CornflowerBlue;
        }
    }
}
