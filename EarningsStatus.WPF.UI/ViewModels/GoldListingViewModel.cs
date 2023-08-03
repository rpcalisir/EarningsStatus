using EarningsStatus.WPF.UI.DataAccess.EntityFramework;
using EarningsStatus.WPF.UI.DataAccess.Utilities;
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
        private readonly ObservableCollection<Gold> _golds;
        public ObservableCollection<Gold> Golds => _golds;

        public GoldListingViewModel()
        {
            _golds = new ObservableCollection<Gold>();

            //_golds.Add(new GoldViewModel(new Gold(10000, 12000, 12, 20, 1350, new DateTime(2023, 3, 27))));
            //_g
            //_golds.Add(new GoldViewModel(new Gold(18000, 23000, 12, 67, 1400, new DateTime(2023, 5, 14))));

            //GoldTableDataCreatorUtility.CreateGoldTableData();

            using (GoldContext context = new GoldContext())
            {
                _golds = new ObservableCollection<Gold>(context.Set<Gold>().ToList());
            }

            MessageBox.Show("OK");
        }
    }
}
