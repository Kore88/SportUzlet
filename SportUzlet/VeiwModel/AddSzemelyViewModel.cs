using MySqlConnector;
using Mysqlx.Session;
using SportUzlet.SQL;
using SportUzlet.Veiw;
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
    internal class AddSzemelyViewModel : INotifyPropertyChanged
    {

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

        public ICommand SzemelyAddCmd { get; }
        public ICommand MegseCmd { get; }

        public AddSzemelyViewModel()
        {
            SzemelyAddCmd = new AddszemelyPageViewCommands(SzemelyAdd);
            MegseCmd = new AddszemelyPageViewCommands(Megse);
        }

        private void Megse(object sender)
        {

        }

        private void SzemelyAdd(object sender)
        {
            MySqlConnection conn = new MySqlConnection(SQL.ConString.conn);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(SQLCommands.cmdInsertSzemely, conn);
                cmd.Parameters.AddWithValue("@nev",Nev);
                cmd.Parameters.AddWithValue("@cim", Cim);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Új személy sikeresen hozzáadva!");
                //view.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }
    }
}
