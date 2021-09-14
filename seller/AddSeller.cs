using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using seller.Entities;

namespace seller {
    public partial class AddSeller : Form {
        private Main mainForm;

        public AddSeller() {
            InitializeComponent();
        }

        public AddSeller(Main main) : this() {
            this.mainForm = main;
        }

        private void addButton_Click(object sender, EventArgs e) {
            int amount = 0;
            try
            {
                amount = int.Parse(this.amountBox.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid amount, try again");
                return;
            }
            this.mainForm.AddSeller(new Seller {
                Name = this.nameBox.Text, District = this.districtBox.Text, SSN = this.persnrBox.Text, Amount = amount
            });
            this.Dispose();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Dispose();
        }
    }
}