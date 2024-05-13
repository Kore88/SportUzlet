using SportUzlet.SQL;
using SportUzlet.Veiw;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using MySqlConnector;
using SportUzlet.Model;
using System.Collections.ObjectModel;

namespace SportUzlet.VeiwModel
{
    internal class RemoveSzemelyPageViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Szemely> _szemelyek;
        public ObservableCollection<Szemely> Szemelyek
        {
            get { return _szemelyek; }
            set
            {
                _szemelyek = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Szemelyek)));
            }
        }


        public AddSzemelyView view;

        public event PropertyChangedEventHandler? PropertyChanged;


        private int _szemelyID;
        public int SzemelyID
        {
            get { return _szemelyID; }
            set
            {
                if (_szemelyID != value)
                {
                    _szemelyID = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SzemelyID)));
                }
            }
        }


        private string _nev;
        public string Nev
        {
            get { return _nev; }
            set
            {
                if (_nev != value)
                {
                    _nev = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Nev)));
                }
            }
        }

        private string _cim;
        public string Cim
        {
            get { return _cim; }
            set
            {
                if (_cim != value)
                {
                    _cim = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Cim)));
                }
            }
        }

        public ICommand SzemelyRemoveCmd { get; }
        public ICommand MegseCmd { get; }

        public RemoveSzemelyPageViewModel()
        {
            SzemelyRemoveCmd = new AddszemelyPageViewCommands(SzemelyRemove);
            MegseCmd = new AddszemelyPageViewCommands(Megse);
            _szemelyek = new ObservableCollection<Szemely>();
        }

        private void Megse(object sender)
        {

        }

        private void SzemelyRemove(object sender)
        {
            MySqlConnection conn = new MySqlConnection(SQL.ConString.conn);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(SQLCommands.cmdDeleteSzemely, conn);
                cmd.Parameters.AddWithValue("@nev", Nev);
                cmd.Parameters.AddWithValue("@cim", Cim);
                cmd.ExecuteNonQuery();
                MessageBox.Show("A személy sikeresen törölve!");
                //view.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }
    }
}
