using EarningsStatus.WPF.UI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EarningsStatus.WPF.UI.ViewModels
{
    public class ProfitStatusViewModel: ViewModelBase
    {
        public ObservableCollection<GoldViewModel> _golds;
        public IEnumerable<GoldViewModel> Golds => _golds;

        public int TotalPortfolioGoldAmount => _golds.Sum(g => g.PurchasedAmount);
        public decimal TotalPortfolioCostAverage => TotalPortfolioGoldAmount/_golds.Sum(g => g.PurchasedPrice);
        public decimal TotalPortfolioLoan => _golds.Sum(g => g.LoanAmount);
        public decimal TotalPortfolioInterest => _golds.Sum(g => g.Interest);
        public decimal TotalPortfolioCost => _golds.Sum(g => g.TotalCost);
        public int CurrentGoldPrice => 1700; //TODO get the current gold price with API
        public decimal ProfitAndLossStatus => (TotalPortfolioGoldAmount * CurrentGoldPrice) - TotalPortfolioInterest;

        public ProfitStatusViewModel()
        {
            _golds = new ObservableCollection<GoldViewModel>();
            //TODO Fill _golds from database
        }

    }
}
