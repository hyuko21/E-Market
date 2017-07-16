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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Forgot_Pass_MouseEnter(object sender, MouseEventArgs e)
        {
            forgotPass_txt.TextDecorations = TextDecorations.Underline;
        }

        private void Forgot_Pass_MouseLeave(object sender, MouseEventArgs e)
        {
            forgotPass_txt.TextDecorations = null;
        }

        private void New_Account_MouseEnter(object sender, MouseEventArgs e)
        {
            newAccount_txt.TextDecorations = TextDecorations.Underline;
        }

        private void New_Account_MouseLeave(object sender, MouseEventArgs e)
        {
            newAccount_txt.TextDecorations = null;
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

        private void EnterBtn_OnClick(object sender, MouseButtonEventArgs e)
        {
            EnterBtn.Background = Brushes.DeepSkyBlue;
        }

        private void EnterBtn_NonClick(object sender, MouseButtonEventArgs e)
        {
            EnterBtn.Background = Brushes.CornflowerBlue;
        }

        private void NewAccount_OnClick(object sender, MouseButtonEventArgs e)
        {
            RegisterWindow rw = new RegisterWindow();
            rw.ShowDialog();
        }

        private void ForgotPass_OnClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void RemindMe_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
