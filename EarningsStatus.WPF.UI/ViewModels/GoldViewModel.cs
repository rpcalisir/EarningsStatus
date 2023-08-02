using EarningsStatus.WPF.UI.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EarningsStatus.WPF.UI.ViewModels
{
    public class GoldViewModel: ViewModelBase
    {
        public Gold _goldModel;

        public int Id => _goldModel.Id;
        public decimal LoanAmount => _goldModel.LoanAmount;
        public decimal LoanRepayment => _goldModel.LoanRepayment;
        public ushort NumberOfInstallments => _goldModel.NumberOfInstallments;
        public int PurchasedAmount => _goldModel.PurchasedAmount;
        public decimal PurchasedPrice => _goldModel.PurchasedPrice;

        public decimal TotalCost => _goldModel.TotalCost;
        public string StartDate => _goldModel.PurchaseDate.ToString("d");
        public string EndDate => _goldModel.EndDate;
        public decimal Interest => _goldModel.Interest;
        public decimal EarningStatus => _goldModel.EarningStatus;

        public GoldViewModel(Gold goldModel)
        {
            _goldModel = goldModel;
        }


    }
}
