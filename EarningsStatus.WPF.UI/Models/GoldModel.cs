using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarningsStatus.WPF.UI.Models
{
    public class GoldModel
    {
        public int Id { get; private set; }
        public decimal LoanAmount { get; private set; }
        public decimal LoanRepayment { get; private set; }
        public ushort NumberOfInstallments { get; private set; }
        public int PurchasedAmount { get; private set; }
        public DateTime StartDate { get; private set; }
        public string EndDate => StartDate.AddMonths(NumberOfInstallments).ToString("dd.MM.yyyy", new CultureInfo("tr-TR"));
        public decimal Interest => LoanRepayment - LoanAmount;

        public GoldModel(decimal loanAmount, decimal loanRepayment, ushort numberOfInstallments, int purchasedAmount, DateTime startDate)
        {
            LoanAmount = loanAmount;
            LoanRepayment = loanRepayment;
            NumberOfInstallments = numberOfInstallments;
            PurchasedAmount = purchasedAmount;
            StartDate = startDate;
        }

    }
}
