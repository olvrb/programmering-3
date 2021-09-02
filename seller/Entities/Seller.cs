using System.Collections.Generic;

namespace seller.Entities {
    public class Seller {
        public string Name { get; set; }
        public string SSN { get; set; }
        public string District { get; set; }
        private List<Article> soldArticles = new List<Article>();

        public int SoldArticles => soldArticles.Count;

        public void SellArticle(Article a) {
            this.soldArticles.Add(a);
        }

        public override string ToString() {
            return this.Name;
        }
    }
}