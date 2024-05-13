using SportUzlet.VeiwModel;
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
using System.Windows.Shapes;

namespace SportUzlet.Veiw
{

    public partial class AddSzemelyView : Window
    {
        private AddSzemelyViewModel viewModel;

        public AddSzemelyView()
        {
            InitializeComponent();
            viewModel = new AddSzemelyViewModel();
            DataContext = viewModel;
        }
    }
}
