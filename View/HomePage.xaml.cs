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

namespace View
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        private LoginPage lp = new LoginPage();

        private Business.System bSys = new Business.System();
        private Model.System mSys = new Model.System();

        public HomePage()
        {
            InitializeComponent();
            UpdateHeaderText(loginBtn, registerBtn, logoutBtn, wMessageTxt);
        }

        private void StoreBtn_OnClick(object sender, MouseButtonEventArgs e)
        {
            StoreBtn.Background = Brushes.DeepSkyBlue;
            StoreBtn_NonClick(sender, e);
            NavigationService.Navigate(new StorePage());
        }

        private void StoreBtn_NonClick(object sender, MouseButtonEventArgs e)
        {
            StoreBtn.Background = Brushes.CornflowerBlue;
        }

        private void LoginBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            loginBtn.TextDecorations = TextDecorations.Underline;
        }

        private void LoginBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            loginBtn.TextDecorations = null;
        }

        private void LoginBtn_OnClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(lp);
        }

        private void RegisterBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            registerBtn.TextDecorations = TextDecorations.Underline;
        }

        private void RegisterBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            registerBtn.TextDecorations = null;
        }

        private void RegisterBtn_OnClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new RegisterPage());
        }

        private void LogoutBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            logoutBtn.TextDecorations = TextDecorations.Underline;
        }

        private void LogoutBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            logoutBtn.TextDecorations = null;
        }

        private void LogoutBtn_OnClick(object sender, MouseButtonEventArgs e)
        {
            LogOut();
        }

        private void WCTxt_MouseEnter(object sender, MouseEventArgs e)
        {
            wMessageTxt.TextDecorations = TextDecorations.Underline;
        }

        private void WCTxt_MouseLeave(object sender, MouseEventArgs e)
        {
            wMessageTxt.TextDecorations = null;
        }

        public void UpdateHeaderText(TextBlock loginBtn, TextBlock registerBtn, TextBlock logoutBtn, TextBlock wMessageTxt)
        {
            if (lp.GetCurrentUser().Name != "visitante")
            {
                UpdateWelcomeMessage(wMessageTxt);
                loginBtn.Visibility = Visibility.Hidden;
                registerBtn.Visibility = Visibility.Hidden;
                logoutBtn.Visibility = Visibility.Visible;
            }
            else
            {
                UpdateWelcomeMessage(wMessageTxt);
                loginBtn.Visibility = Visibility.Visible;
                registerBtn.Visibility = Visibility.Visible;
                logoutBtn.Visibility = Visibility.Collapsed;
            }
        }

        private void UpdateWelcomeMessage(TextBlock wMessageTxt)
        {
            var currentUser = lp.GetCurrentUser();
            if (!currentUser.Admin) wMessageTxt.Text = $"Seja bem vindo, {currentUser.Name}!";
        }

        public void LogOut()
        {
            var result = MessageBox.Show("Você realmente deseja sair?", "Log out", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                mSys = bSys.Select().Single();
                bSys.Initialize(mSys);
                bSys.Update(mSys);
                UpdateHeaderText(loginBtn, registerBtn, logoutBtn, wMessageTxt);
            }
        }

        public Model.System GetSystemStatus()
        {
            return bSys.Select().Single();
        }
    }
}
