﻿using System;
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
        private Business.User bUser = new Business.User();
        
        private bool agreeTermsOfService;

        public RegisterWindow()
        {
            InitializeComponent();
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

        private void TermsOfService_Checked(object sender, RoutedEventArgs e)
        {
            agreeTermsOfService = true;
        }

        private void TermsOfService_Unchecked(object sender, RoutedEventArgs e)
        {
            agreeTermsOfService = false;
        }

        private void CancelBtn_OnClick(object sender, MouseButtonEventArgs e)
        {
            CancelBtn.Background = Brushes.Red;
        }

        private void CancelBtn_NonClick(object sender, MouseButtonEventArgs e)
        {
            CancelBtn.Background = Brushes.IndianRed;
            DialogResult = false;
        }

        private void RegisterBtn_OnClick(object sender, MouseButtonEventArgs e)
        {
            RegisterBtn.Background = Brushes.DeepSkyBlue;

            string rFields = RemaingFields();
            string passParity = CheckPassParity(password_txt.Password, confirmPass_txt.Password);
            if (rFields == "" && passParity == "")
            {
                var encryptedPass = Business.Security.Encrypt(password_txt.Password);
                Model.User user = new Model.User { Id = GetId(), Name = userName_txt.Text, Password = encryptedPass, Admin = false };
                bUser.Insert(user);
                DialogResult = true;
            }
            else if(rFields != "")
            {
                MessageBox.Show(rFields, "Campos Obrigatórios", MessageBoxButton.OK);
                RegisterBtn.Background = Brushes.CornflowerBlue;
            }
            else
            {
                MessageBox.Show(passParity, "Erro!", MessageBoxButton.OK);
                RegisterBtn.Background = Brushes.CornflowerBlue;
            }
        }

        private void RegisterBtn_NonClick(object sender, MouseButtonEventArgs e)
        {
            RegisterBtn.Background = Brushes.CornflowerBlue;
        }

        public string RemaingFields()
        {
            StringBuilder output = new StringBuilder();

            if (name_txt.Text == "") {
                output.Append("- Nome\n");
            }

            if (lastName_txt.Text == "")
            {
                output.Append("- Sobrenome\n");
            }

            if (phone_txt.Text == "")
            {
                output.Append("- Telefone\n");
            }

            if (state_txt.Text == "")
            {
                output.Append("- Estado\n");
            }

            if (city_txt.Text == "")
            {
                output.Append("- Cidade\n");
            }

            if (district_txt.Text == "")
            {
                output.Append("- Bairro\n");
            }

            if (street_txt.Text == "")
            {
                output.Append("- Rua\n");
            }

            if (houseNum_txt.Text == "")
            {
                output.Append("- Nº\n");
            }

            if (userName_txt.Text == "")
            {
                output.Append("- Usuário\n");
            }

            if (password_txt.Password == "")
            {
                output.Append("- Senha\n");
            }

            if (confirmPass_txt.Password == "")
            {
                output.Append("- Senha (Corfimação)\n");
            }

            if (!agreeTermsOfService)
            {
                output.Append("- Termos de serviço\n");
            }

            return output.ToString();
        }

        public string CheckPassParity(string oriPass, string confPass)
        {   
            if(confirmPass_txt.Password != "" || password_txt.Password != "")
            {
                if (confirmPass_txt.Password != password_txt.Password) return "- A senhas informadas não são iguais";
                return "";
            }
            return "nef";
        }

        public int GetId()
        {
            bool inUse = false;
            int id;
            Random rnd = new Random();

            do
            {
                id = rnd.Next(100, 1000);
                if (bUser.Select().Where(r => r.Id == id).Count() == 0)
                {
                    break;
                }
                else
                {
                    inUse = true;
                }
            } while (inUse);

            return id;
        }
    }
}
