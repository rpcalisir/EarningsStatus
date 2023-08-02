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

        public int PortfolioGoldAmount => _golds.Sum(g => g.PurchasedAmount);
        public decimal PortfolioCostAverage => PortfolioGoldAmount/_golds.Sum(g => g.PurchasedPrice);
        public decimal PortfolioLoan => _golds.Sum(g => g.LoanAmount);
        public decimal PortfolioInterest => _golds.Sum(g => g.Interest);
        public decimal PortfolioCost => _golds.Sum(g => g.TotalCost);
        public int CurrentGoldPrice => 1700; //TODO get the current gold price with API
        public decimal PortfolioEarningStatus => (PortfolioGoldAmount * CurrentGoldPrice) - PortfolioInterest;

        public ProfitStatusViewModel()
        {
            _golds = new ObservableCollection<GoldViewModel>();
            //TODO Fill _golds from database
        }

    }
}
