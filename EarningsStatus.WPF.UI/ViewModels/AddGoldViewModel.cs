using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EarningsStatus.WPF.UI.ViewModels
{
    public class AddGoldViewModel: ViewModelBase
    {
        private decimal _loanAmount;
        public decimal LoanAmount
        {
            get
            {
                return _loanAmount;
            }
            set
            {
                _loanAmount = value;
                OnPropertyChanged(nameof(LoanAmount));
            }
        }

        private decimal _loanRepayment;
        public decimal LoanRepayment
        {
            get
            {
                return _loanRepayment;
            }
            set
            {
                _loanRepayment = value;
                OnPropertyChanged(nameof(LoanRepayment));
            }
        }

        private ushort _numberOfInstallments;
        public ushort NumberOfInstallments
        {
            get
            {
                return _numberOfInstallments;
            }
            set
            {
                _numberOfInstallments = value;
                OnPropertyChanged(nameof(NumberOfInstallments));
            }
        }

        private DateTime _purchaseDate;
        public DateTime PurchaseDate
        {
            get
            {
                return _purchaseDate;
            }
            set
            {
                _purchaseDate = value;
                OnPropertyChanged(nameof(PurchaseDate));
            }
        }

        private int _purchasedAmount;
        public int PurchasedAmount
        {
            get
            {
                return _purchasedAmount;
            }
            set
            {
                _purchasedAmount = value;
                OnPropertyChanged(nameof(PurchasedAmount));
            }
        }

        public ICommand AddGoldToPortfolioCommand { get; }
        public ICommand AddGoldCancelCommand { get; }

    }
}
