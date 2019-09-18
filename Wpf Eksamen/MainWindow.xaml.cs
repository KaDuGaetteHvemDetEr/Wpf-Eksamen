using System;
using System.Collections;
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

namespace Wpf_Eksamen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Client> clientList = new List<Client>();
        

        public MainWindow()
        {
            InitializeComponent();
            Updatebinding();

        }

        private void Updatebinding()
        {
            InfoBox.ItemsSource = clientList;
            InfoBox.DisplayMemberPath = "Full_Info";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataAcc db = new DataAcc();
            clientList = db.Getinfo();

            Updatebinding(); 
        }
        /*Chritian og Nicolai har hjulpet med denne kode */
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DataAcc db = new DataAcc();

            db.InsertPrivat(FNamEbox.Text, LNamEbox.Text, Adrbox.Text, int.Parse(PsTBox.Text), TeLeBox.Text);

            FNamEbox.Text = "";
            LNamEbox.Text = "";
            TeLeBox.Text = "";
            PsTBox.Clear();
            Adrbox.Text = "";
        }
    }

        
}
