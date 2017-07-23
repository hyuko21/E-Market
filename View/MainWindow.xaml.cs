using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Business.System bSys = new Business.System();
        private Model.System mSys = new Model.System();

        public MainWindow()
        {
            InitializeComponent();
            mSys = bSys.Select().Single();
            bSys.Initialize(mSys);
            bSys.Update(mSys);
            Main.NavigationService.Navigate(new HomePage());
        }
    }
}
