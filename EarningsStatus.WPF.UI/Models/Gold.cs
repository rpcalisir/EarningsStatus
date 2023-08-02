using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarningsStatus.WPF.UI.Models
{
    public class Gold
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }

        public decimal LoanAmount { get; private set; }
        public decimal LoanRepayment { get; private set; }
        public ushort NumberOfInstallments { get; private set; }
        public int PurchasedAmount { get; private set; }
        public decimal PurchasedPrice { get; private set; }
        public decimal TotalCost => PurchasedAmount * PurchasedPrice;
        public DateTime PurchaseDate { get; private set; }
        public string EndDate => PurchaseDate.AddMonths(NumberOfInstallments).ToString("dd.MM.yyyy", new CultureInfo("tr-TR"));
        public decimal Interest => LoanRepayment - LoanAmount;
        public int CurrentGoldPrice => 1700; //TODO API
        public decimal EarningStatus => (PurchasedAmount * CurrentGoldPrice) - Interest;

        public Gold(decimal loanAmount, decimal loanRepayment, ushort numberOfInstallments, int purchasedAmount, decimal purchasedPrice, DateTime purchaseDate)
        {
            LoanAmount = loanAmount;
            LoanRepayment = loanRepayment;
            NumberOfInstallments = numberOfInstallments;
            PurchasedAmount = purchasedAmount;
            PurchasedPrice = purchasedPrice;
            PurchaseDate = purchaseDate;
        }

    }
}
