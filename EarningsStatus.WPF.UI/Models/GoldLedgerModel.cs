using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarningsStatus.WPF.UI.Models
{
    public class GoldLedgerModel
    {
        private readonly List<GoldModel> _golds;

        public GoldLedgerModel()
        {
            _golds = new List<GoldModel>();
        }

        public void AddGold(GoldModel gold)
        {
            _golds.Add(gold);
        }

        public IEnumerable<GoldModel > GetGolds()
        {
            return _golds;
        }
    }
}
