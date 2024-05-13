using Mysqlx.Prepare;
using SportUzlet.Veiw;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SportUzlet.VeiwModel
{
    internal class MainPageVeiwModel : INotifyPropertyChanged
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

        public ICommand AddSzemelyCmd { get; }
        public ICommand AddTermekCmd { get; }
        public ICommand RemoveSzemelyCmd { get; }

        public MainPageVeiwModel()
        {
            AddSzemelyCmd = new MainPageViewCommands(AddSzemely);
            AddTermekCmd = new MainPageViewCommands(AddTermek);
            RemoveSzemelyCmd = new MainPageViewCommands(RemoveSzemely);
        }

        private void AddSzemely(object sender)
        {
             var addSzemelyView = new AddSzemelyView();
            addSzemelyView.Show();
        }
        private void AddTermek(object sender)
        {
            var addTermekView = new AddTermekView();
            addTermekView.Show();
        }

        private void RemoveSzemely(object sender)
        {
            var removeSzemelyView = new RemoveSzemelyView();
            removeSzemelyView.Show();
        }
    }
}
