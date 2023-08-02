using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarningsStatus.WPF.UI.Models
{
    public class PortfolioModel
    {
        private readonly GoldLedgerModel _goldLedgerModel;

        public PortfolioModel()
        {
            _goldLedgerModel = new GoldLedgerModel();
        }

        public void AddGoldToPortfolio(GoldModel goldModel)
        {
            _goldLedgerModel.AddGold(goldModel);
        }

        public IEnumerable<GoldModel> GetGolds()
        {
            return _goldLedgerModel.GetGolds();
        }
    }
}
