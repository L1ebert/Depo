using Depo.Class;
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

namespace Depo.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageMenu.xaml
    /// </summary>
    public partial class PageMenu : Page
    {
        public PageMenu()
        {
            InitializeComponent();
        }

        private void HL1_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameTitle.Navigate(new PageMain.PageTA());
            ClassFrame.FrameBody.Navigate(new PageMain.PageBA());
        }

        private void HL2_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageMain.PageBad());
            ClassFrame.FrameTitle.Navigate(new PageMain.PageTad());
        }

        private void HL3_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
