using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarningsStatus.WPF.UI.Models
{
    public class Gold
    {
        public int Id { get; private set; }
        public decimal LoanAmount { get; private set; }
        public decimal LoanRepayment { get; private set; }
        public ushort NumberOfInstallments { get; private set; }
        public int PurchasedAmount { get; private set; }
        public decimal PurchasedPrice { get; private set; }
        public decimal TotalCost => PurchasedAmount * PurchasedPrice;
        public DateTime StartDate { get; private set; }
        public string EndDate => StartDate.AddMonths(NumberOfInstallments).ToString("dd.MM.yyyy", new CultureInfo("tr-TR"));
        public decimal Interest => LoanRepayment - LoanAmount;
        public Gold(decimal loanAmount, decimal loanRepayment, ushort numberOfInstallments, int purchasedAmount, decimal purchasedPrice, DateTime startDate)
        {
            LoanAmount = loanAmount;
            LoanRepayment = loanRepayment;
            NumberOfInstallments = numberOfInstallments;
            PurchasedAmount = purchasedAmount;
            PurchasedPrice = purchasedPrice;
            StartDate = startDate;
        }

    }
}
