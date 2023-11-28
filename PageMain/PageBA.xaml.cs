using Depo.Model;
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
    /// Логика взаимодействия для PageBA.xaml
    /// </summary>
    public partial class PageBA : Page
    {
        public PageBA()
        {
            InitializeComponent();
            FloorCmb.SelectedValuePath = "ID";
            FloorCmb.DisplayMemberPath = "Name";
            FloorCmb.ItemsSource = App.context.Floor.ToList();

            NumberVanCmb.SelectedValuePath = "ID";
            NumberVanCmb.DisplayMemberPath = "Number";
            NumberVanCmb.ItemsSource = App.context.Van.ToList();

            WorkCmb.SelectedValuePath = "ID";
            WorkCmb.DisplayMemberPath = "Name";
            WorkCmb.ItemsSource = App.context.Work.ToList();

            WorkNameCmb.SelectedValuePath = "ID";
            WorkNameCmb.DisplayMemberPath = "Name";
            WorkNameCmb.ItemsSource = App.context.PreventiveWork.ToList();

            JournalDG.ItemsSource = App.context.Record.ToList();
        }

        private void JournalDG_Loaded(object sender, RoutedEventArgs e)
        {
            JournalDG.ItemsSource = App.context.Record.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(WorkNameCmb.Text))
                mes += "Выберите название работы\n";
            if (string.IsNullOrWhiteSpace(WorkCmb.Text))
                mes += "Выберите работу\n";
            if (string.IsNullOrWhiteSpace(NumberVanCmb.Text))
                mes += "Выберите номер вагона\n";
            if (string.IsNullOrWhiteSpace(FloorCmb.Text))
                mes += "Выберите этажность\n";
            if (string.IsNullOrWhiteSpace(DateSelectionDP.Text))
                mes += "Выберите дату\n";
            if (string.IsNullOrWhiteSpace(PriceTb.Text))
                mes += "Введите стоимость\n";
            if(mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Record record = new Record
            {
                Work = WorkNameCmb.SelectedItem as Work,
                Van = NumberVanCmb.SelectedItem as Van,
                Date = Convert.ToDateTime(DateSelectionDP.Text),
                Price = Convert.ToInt32(PriceTb.Text)
            };
            App.context.Record.Add(record);
            App.context.SaveChanges();
            MessageBox.Show("Запись обновлена");

            PriceTb.Text = "";
            FloorCmb.Text = "";
            NumberVanCmb.Text = "";
            WorkCmb.Text = "";
            WorkNameCmb.Text = "";
        }

        private void WorkCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedWC = Convert.ToInt32(WorkNameCmb.SelectedValue);
            WorkCmb.ItemsSource = App.context.Work.Where(x => x.PreventiveWork.ID == selectedWC).ToList();
        }

        private void FloorCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedFC = Convert.ToInt32(FloorCmb.SelectedValue);
            NumberVanCmb.ItemsSource = App.context.Van.Where(x => x.Floor.ID == selectedFC).ToList();
        }
    }
}
