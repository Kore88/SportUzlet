using MySql.Data.MySqlClient;
using SportUzlet.Model;
using SportUzlet.VeiwModel;
using System.Collections.ObjectModel;
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

namespace SportUzlet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Szemely> szemelyek = new ObservableCollection<Szemely>();
        ObservableCollection<Termek> termekek = new ObservableCollection<Termek>();

        MainPageVeiwModel viewModel;

        public MainWindow()
        {
            InitializeComponent();
            viewModel = new MainPageVeiwModel();
            DataContext = viewModel;
            DataGridFeltoltes();
        }



        public void DataGridFeltoltes()
        {
            MySqlConnection conn = new MySqlConnection(SQL.ConString.conn);
            MySqlConnection conn1 = new MySqlConnection(SQL.ConString.conn);
            try
            {
                conn.Open();
                conn1.Open();

                MySqlCommand cmd = new MySqlCommand(SQL.SQLCommands.cmdAllSzemely,conn);
                MySqlCommand cmd1 = new MySqlCommand(SQL.SQLCommands.cmdAllTermek, conn1);
                MySqlDataReader dr = cmd.ExecuteReader();
                MySqlDataReader dr1 = cmd1.ExecuteReader();

                while (dr.Read())
                {
                    string n = dr.GetString(0);
                    string c = dr.GetString(1);

                    Szemely sz = new Szemely(c,n);
                    szemelyek.Add(sz);
                }
                dgRacsSzemelyek.ItemsSource = szemelyek;

                while (dr1.Read())
                {
                    string tn = dr1.GetString(0);
                    int ea = dr1.GetInt32(1);

                    Termek tr = new Termek(tn, ea);
                    termekek.Add(tr);
                }
                dgRacsTermekek.ItemsSource = termekek;

                conn.Close();
                conn1.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }

    }
}