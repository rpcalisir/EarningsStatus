using EarningsStatus.WPF.UI.DataAccess.EntityFramework;
using EarningsStatus.WPF.UI.Models;
using EarningsStatus.WPF.UI.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EarningsStatus.WPF.UI.Commands
{
    public class AddGoldToPortfolioCommand : CommandBase
    {
        private readonly AddGoldViewModel _addGoldViewModel;

        public AddGoldToPortfolioCommand(AddGoldViewModel addGoldViewModel)
        {
            _addGoldViewModel = addGoldViewModel;
        }

        public override void Execute(object? parameter)
        {
            var gold = new Gold(_addGoldViewModel.LoanAmount, _addGoldViewModel.LoanRepayment, _addGoldViewModel.NumberOfInstallments, _addGoldViewModel.PurchasedAmount, _addGoldViewModel.PurchasedPrice, _addGoldViewModel.PurchaseDate);

            using (var context = new GoldContext())
            {
                var addedEntity = context.Entry(gold);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
                MessageBox.Show("Altın Portföy'e eklendi!");
            }
        }
    }
}
