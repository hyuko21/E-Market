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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private Business.User bUser = new Business.User();
        private Business.AccessLog bAccsLog = new Business.AccessLog();
        private Business.System bSys = new Business.System();

        private Model.System mSys = new Model.System();

        public LoginPage()
        {
            InitializeComponent();
            UpdateLogInText();
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

            if (userName_txt.Text == "" || password_txt.Password == "")
            {
                userName_txt.BorderBrush = Brushes.Red;
                password_txt.BorderBrush = Brushes.Red;
            }
            else
            {
                List<Model.User> lUser = bUser.Select();
                if (lUser.Count() > 0)
                {
                    if (lUser.Where(r => r.Name == userName_txt.Text && Business.Security.VerifyInput(password_txt.Password, r.Password)).Count() > 0)
                    {
                        mSys.CurrentUser = lUser.Where(r => r.Name == userName_txt.Text).Single();
                        if (!mSys.CurrentUser.Admin)
                        {
                            mSys.UserLoged = true;
                            if (remindMe_CheckBox.IsChecked == true) mSys.LastRecentlyUser = mSys.CurrentUser.Name;
                            bSys.Update(mSys);

                            var id = lUser.Where(r => r.Name == userName_txt.Text).Single().Id;
                            var accs = new Model.AccessLog { Id = bAccsLog.GetID(), UserId = id, Date = DateTime.Now };
                            bAccsLog.Insert(accs);

                            UpdateLogInText();
                            EnterBtn.Background = Brushes.CornflowerBlue;
                            NavigationService.Navigate(new StorePage());
                        }
                        else
                        {
                            UpdateLogInText();
                            EnterBtn.Background = Brushes.CornflowerBlue;
                            NavigationService.Navigate(new AdminPage());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nome de usuário, ou senha, incorreto", "Erro", MessageBoxButton.OK);
                        EnterBtn.Background = Brushes.CornflowerBlue;
                    }
                }
                else
                {
                    MessageBox.Show("Usuário não cadastrado", "Erro", MessageBoxButton.OK);
                    EnterBtn.Background = Brushes.CornflowerBlue;
                }
            }
        }

        private void UpdateLogInText()
        {
            var name = bSys.Select().Single().LastRecentlyUser;
            userName_txt.Text = name;
        }

        public Model.User GetCurrentUser()
        {
            return bSys.Select().Single().CurrentUser;
        }

        private void EnterBtn_NonClick(object sender, MouseButtonEventArgs e)
        {
            EnterBtn.Background = Brushes.CornflowerBlue;
        }

        private void New_Account_MouseEnter(object sender, MouseEventArgs e)
        {
            newAccount_txt.TextDecorations = TextDecorations.Underline;
        }

        private void New_Account_MouseLeave(object sender, MouseEventArgs e)
        {
            newAccount_txt.TextDecorations = null;
        }

        private void NewAccount_OnClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new RegisterPage());
        }

        private void Forgot_Pass_MouseEnter(object sender, MouseEventArgs e)
        {
            forgotPass_txt.TextDecorations = TextDecorations.Underline;
        }

        private void Forgot_Pass_MouseLeave(object sender, MouseEventArgs e)
        {
            forgotPass_txt.TextDecorations = null;
        }

        private void ForgotPass_OnClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void LoginBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            loginBtn.TextDecorations = TextDecorations.Underline;
        }

        private void LoginBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            loginBtn.TextDecorations = null;
        }

        private void RegisterBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            registerBtn.TextDecorations = TextDecorations.Underline;
        }

        private void RegisterBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            registerBtn.TextDecorations = null;
        }

        private void RegisterPageBtn_OnClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new RegisterPage());
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
    }
}
