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
        public GoldModel _goldModel;
        public int Id => _goldModel.Id;
        public decimal LoanAmount => _goldModel.LoanAmount;
        public decimal LoanRepayment => _goldModel.LoanRepayment;
        public ushort NumberOfInstallments => _goldModel.NumberOfInstallments;
        public int PurchasedAmount => _goldModel.PurchasedAmount;
        public DateTime StartDate => _goldModel.StartDate;
        public string EndDate => _goldModel.EndDate;
        public decimal Interest => _goldModel.Interest;

        public GoldViewModel(GoldModel goldModel)
        {
            _goldModel = goldModel;
        }


    }
}
