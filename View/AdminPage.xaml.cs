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
    /// Interaction logic for AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        Business.User bUser = new Business.User();
        Business.AccessLog bAccs = new Business.AccessLog();
        HomePage hp = new HomePage();

        public AdminPage()
        {
            InitializeComponent();
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
            NavigationService.GoBack();
        }

        private void UsersBtn_OnClick(object sender, MouseButtonEventArgs e)
        {
            usersBtn.Background = Brushes.DeepSkyBlue;

            removeBtn.Visibility = Visibility.Visible;
            removeAllBtn.Visibility = Visibility.Visible;

            gridContentTxt.Content = "Usuários";
            gridContentTxt.Visibility = Visibility.Visible;

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = bUser.Select().Where(r => r.Admin == false);
        }

        private void UsersBtn_NonClick(object sender, MouseButtonEventArgs e)
        {
            usersBtn.Background = Brushes.CornflowerBlue;
        }

        private void AccsLogBtn_OnClick(object sender, MouseButtonEventArgs e)
        {
            accsLogBtn.Background = Brushes.DeepSkyBlue;

            removeBtn.Visibility = Visibility.Visible;
            removeAllBtn.Visibility = Visibility.Visible;

            gridContentTxt.Content = "Acessos";
            gridContentTxt.Visibility = Visibility.Visible;

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = bAccs.Select();
        }

        private void AccsLogBtn_NonClick(object sender, MouseButtonEventArgs e)
        {
            accsLogBtn.Background = Brushes.CornflowerBlue;
        }

        private void ProductsBtn_OnClick(object sender, MouseButtonEventArgs e)
        {
            productsBtn.Background = Brushes.DeepSkyBlue;
        }

        private void ProductsBtn_NonClick(object sender, MouseButtonEventArgs e)
        {
            productsBtn.Background = Brushes.CornflowerBlue;
        }

        private void NewAdminBtn_OnClick(object sender, MouseButtonEventArgs e)
        {
            newAdminBtn.Background = Brushes.DeepSkyBlue;
        }

        private void NewAdminBtn_NonClick(object sender, MouseButtonEventArgs e)
        {
            newAdminBtn.Background = Brushes.CornflowerBlue;
        }

        private void RemoveBtn_OnClick(object sender, MouseButtonEventArgs e)
        {
            removeBtn.Background = Brushes.Red;
            if(dataGrid.SelectedItem != null)
            {
                var result = MessageBox.Show("Deseja remover o dado selecionado?", "Remoção", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    var selectedType = dataGrid.SelectedItem.GetType().Name;
                    if (selectedType == bUser.GetType().Name)
                    {
                        bUser.Delete(dataGrid.SelectedItem as Model.User);
                        UsersBtn_OnClick(sender, e);
                    }
                    else if(selectedType == bAccs.GetType().Name)
                    {
                        bAccs.Delete(dataGrid.SelectedItem as Model.AccessLog);
                        AccsLogBtn_OnClick(sender, e);
                    }
                }
            }
            RemoveBtn_NonClick(sender, e);
        }

        private void RemoveBtn_NonClick(object sender, MouseButtonEventArgs e)
        {
            removeBtn.Background = Brushes.IndianRed;
        }

        private void RemoveAllBtn_OnClick(object sender, MouseButtonEventArgs e)
        {
            var result = MessageBox.Show("Deseja remover TODOS os dados?", "Remoção", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                removeAllBtn.Background = Brushes.Red;

                var selectedType = dataGrid.SelectedItem.GetType().Name;
                if (selectedType == bUser.GetType().Name)
                {
                    bUser.Clear();
                    UsersBtn_OnClick(sender, e);
                }
                else if (selectedType == bAccs.GetType().Name)
                {
                    bAccs.Clear();
                    AccsLogBtn_OnClick(sender, e);
                }
            }
            RemoveAllBtn_NonClick(sender, e);
        }

        private void RemoveAllBtn_NonClick(object sender, MouseButtonEventArgs e)
        {
            removeAllBtn.Background = Brushes.IndianRed;
        }
    }
}
