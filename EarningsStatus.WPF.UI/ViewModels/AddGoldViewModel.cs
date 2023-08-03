using EarningsStatus.WPF.UI.Commands;
using EarningsStatus.WPF.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
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

        private int _purchasedPrice;
        public int PurchasedPrice
        {
            get
            {
                return _purchasedPrice;
            }
            set
            {
                _purchasedPrice = value;
                OnPropertyChanged(nameof(PurchasedPrice));
            }
        }

        private DateTime _purchaseDate = DateTime.Now;
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


        public ICommand AddGoldToPortfolioCommand { get; }
        public ICommand CancelCommand { get; }

        public AddGoldViewModel()
        {
            AddGoldToPortfolioCommand = new AddGoldToPortfolioCommand(this);
        }
    }
}
