using MySqlConnector;
using SportUzlet.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SportUzlet.VeiwModel
{
    internal class AddTermekViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private int _termekID;
        public int TermekID
        {
            get { return _termekID; }
            set
            {
                if (_termekID != value)
                {
                    _termekID = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TermekID)));
                }
            }
        }


        private string _termekNev;
        public string TermekNev
        {
            get { return _termekNev; }
            set
            {
                if (_termekNev != value)
                {
                    _termekNev = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TermekNev)));
                }
            }
        }

        private string _egysegar;
        public string Egysegar
        {
            get { return _egysegar; }
            set
            {
                if (_egysegar != value)
                {
                    _egysegar = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Egysegar)));
                }
            }
        }

        public ICommand TermekAddCmd { get; }
        public ICommand MegseCmd { get; }

        public AddTermekViewModel()
        {
            TermekAddCmd = new AddszemelyPageViewCommands(TermekAdd);
            MegseCmd = new AddszemelyPageViewCommands(Megse);
        }
        private void Megse(object sender)
        {

        }
        private void TermekAdd(object sender)
        {
            MySqlConnection conn = new MySqlConnection(SQL.ConString.conn);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(SQLCommands.cmdInsertTermek, conn);
                cmd.Parameters.AddWithValue("@termekNev", TermekNev);
                cmd.Parameters.AddWithValue("@egysegar", Egysegar);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Új termék sikeresen hozzáadva!");
                //view.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }
    }
}
