using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using seller.Entities;

namespace seller {
    public partial class Main : Form {
        private List<Seller> sellers = new List<Seller>();

        public Main() {
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e) {
            this.PopulateSellers();
            this.ReloadData();
        }

        private void ReloadData() {
            // Clear textbox before adding new data.
            this.infoBox.Text = "";
            
            // Sort sellers before writing out data.
            this.SortSellers();
            

            // Iterate through every tier and write out every seller under their correct tier.
            for (int i = 1; i <= 4; i++) {
                List<Seller> currentTier = this.GetSellersForTier(i);
                this.infoBox.Text += $"{currentTier.Count} seller(s) are in tier {i}.\n";
                foreach (Seller s in currentTier) {
                    this.infoBox.Text +=
                        $"Name: {s.Name}\nPersnr: {s.SSN}\nDistrikt: {s.District}\nAmount: {s.SoldArticles}\n\n";
                }

                this.infoBox.Text += "\n\n";
            }
        }

        private void SortSellers() {
            this.sellers = this.sellers.OrderBy(x => x.SoldArticles).ToList();
        }


        public void AddSeller(Seller s) {
            this.sellers.Add(s);
        }

        private void addUserButton_Click(object sender, System.EventArgs e) {
            // Show dialog for user to add new seller
            AddSeller form = new AddSeller(this);
            form.ShowDialog(this);
            this.ReloadData();
        }


        private void PopulateSellers() {
            this.sellers.Add(new Seller { Name = "blip", District = "123", SSN = "0204150072" });
            this.sellers.Add(new Seller { Name = "blup", District = "123", SSN = "0304150072" });
            this.sellers.Add(new Seller { Name = "asud", District = "123", SSN = "0404150072" });
            this.sellers.Add(new Seller { Name = "fdsa", District = "123", SSN = "0504150072" });
            this.sellers.Add(new Seller { Name = "fdsa", District = "123", SSN = "0604150072" });

            // Add random amount of articles for each seller.
            Random r = new Random();
            foreach (Seller s in this.sellers) {
                int amount = r.Next(0, 500);
                for (int i = 0; i <= amount; i++) {
                    s.SellArticle(new Article());
                }
            }
        }

        private List<Seller> GetSellersForTier(int i) {
            // Get sellers based on assignment instructions.
            switch (i) {
                case 1: return this.sellers.Where(x => x.SoldArticles <= 50).ToList();
                case 2: return this.sellers.Where(x => x.SoldArticles >= 50 && x.SoldArticles <= 99).ToList();
                case 3: return this.sellers.Where(x => x.SoldArticles >= 100 && x.SoldArticles <= 199).ToList();
                case 4: return this.sellers.Where(x => x.SoldArticles > 199).ToList();
                default:
                    return null;
            }
        }
    }
}