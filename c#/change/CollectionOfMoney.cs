using System.Collections.Generic;
using System.Linq;

namespace change {
    public class CollectionOfMoney {

        public List<Money> Moneys = new List<Money>();

        public void AddMoney(Money m) {


            Money temp = this.Moneys.Find(x => x.Type == m.Type);
            
            if (temp != null) {
                temp.Amount++;
                return;
            }

            Moneys.Add(m);
        }

        public int Sum() {
            return this.Moneys.Select(x => x.GetWorth()).Sum();
        }
    }
}