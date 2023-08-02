using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarningsStatus.WPF.UI.Models
{
    public class GoldLedger
    {
        private readonly List<Gold> _golds;

        public GoldLedger()
        {
            _golds = new List<Gold>();
        }

        public void AddGold(Gold gold)
        {
            _golds.Add(gold);
        }

        public IEnumerable<Gold > GetGolds()
        {
            return _golds;
        }
    }
}
