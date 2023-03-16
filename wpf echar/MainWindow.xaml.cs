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
using Bogus;

namespace wpf_echar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        class User
        {
            public string Name { get; set; }
            public string SurName { get; set; }

            public DateOnly Birth { get; set; }


            //public override string ToString()
            //{
            //    return $"Name:{Name}Surname:{SurName}Date{Birth.ToString("YY:MM:DD")}";
            //}
        }

        public MainWindow()
        {
            InitializeComponent();
        }


        private void btn1_Click(object sender, RoutedEventArgs e)
        {

            listbx.Items.Add(new { Name = txtbx1.Text ,SurName = txtbx2.Text, Birth = clndr});
        }

        private void bnt2_Click(object sender, RoutedEventArgs e)
        {
            listbx.Items.Remove(listbx.SelectedItem);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            listbx.Items.Clear();
        }
    }
}
