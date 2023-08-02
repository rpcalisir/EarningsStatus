using EarningsStatus.WPF.UI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace EarningsStatus.WPF.UI.ViewModels
{
    public class GoldListingViewModel: ViewModelBase
    {
        public ObservableCollection<GoldViewModel> _golds;

        public IEnumerable<GoldViewModel> Golds => _golds;

        public ICommand SwitchToAddGoldMenuCommand { get; }

        public GoldListingViewModel()
        {
            _golds = new ObservableCollection<GoldViewModel>();

            _golds.Add(new GoldViewModel(new Gold(10000, 12000, 12, 20, 1350, new DateTime(2023, 3, 27))));
            _golds.Add(new GoldViewModel(new Gold(18000, 23000, 12, 67, 1400, new DateTime(2023, 5, 14))));

            MessageBox.Show("OK");
        }
    }
}
