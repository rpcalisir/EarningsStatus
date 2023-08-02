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

            _golds.Add(new GoldViewModel(new GoldModel(10000, 12000, 12, 20, new DateTime(2023, 8, 2))));

            MessageBox.Show("OK");
        }
    }
}
