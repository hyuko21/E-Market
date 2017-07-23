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
    /// Interaction logic for StorePage.xaml
    /// </summary>
    public partial class StorePage : Page
    {
        HomePage hp = new HomePage();
        Model.Warehouse mw = new Model.Warehouse();

        public StorePage()
        {
            InitializeComponent();
            dataGrid.ItemsSource = mw.GetProducts();
            hp.UpdateHeaderText(loginBtn, registerBtn, logoutBtn, wMessageTxt);
        }

        private void WCTxt_MouseEnter(object sender, MouseEventArgs e)
        {
            wMessageTxt.TextDecorations = TextDecorations.Underline;
        }

        private void WCTxt_MouseLeave(object sender, MouseEventArgs e)
        {
            wMessageTxt.TextDecorations = null;
        }

        private void WCTxt_OnClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new HomePage());
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
            NavigationService.Navigate(new LoginPage());
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
            hp.LogOut();
            NavigationService.Navigate(new HomePage());
        }

        private void ClearCartBtn_OnClick(object sender, MouseButtonEventArgs e)
        {
            clearCartBtn.Background = Brushes.Red;
        }

        private void ClearCartBtn_NonClick(object sender, MouseButtonEventArgs e)
        {
            clearCartBtn.Background = Brushes.IndianRed;
        }

        private void AddToCartBtn_OnClick(object sender, MouseButtonEventArgs e)
        {
            addToCartBtn.Background = Brushes.DeepSkyBlue;
        }

        private void AddToCartBtn_NonClick(object sender, MouseButtonEventArgs e)
        {
            addToCartBtn.Background = Brushes.CornflowerBlue;
        }

        private void ReturnBtn_OnClick(object sender, MouseButtonEventArgs e)
        {
            returnBtn.Background = Brushes.Red;
            ReturnBtn_NonClick(sender, e);
            NavigationService.GoBack();
        }

        private void ReturnBtn_NonClick(object sender, MouseButtonEventArgs e)
        {
            returnBtn.Background = Brushes.IndianRed;
        }

        private void FinalizeBtn_OnClick(object sender, MouseButtonEventArgs e)
        {
            finalizeBtn.Background = Brushes.ForestGreen;
            if (hp.GetSystemStatus().UserLoged) {
                FinalizeBtn_NonClick(sender, e);
                MessageBox.Show("Pedido realizado com sucesso", "Pedido", MessageBoxButton.OK);
            }
            else
            {
                FinalizeBtn_NonClick(sender, e);
                NavigationService.Navigate(new LoginPage());
            }
        }

        private void FinalizeBtn_NonClick(object sender, MouseButtonEventArgs e)
        {
            finalizeBtn.Background = Brushes.MediumSeaGreen;
        }
    }
}
