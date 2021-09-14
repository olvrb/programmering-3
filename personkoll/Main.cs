using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personkoll {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void processButton_Click(object sender, EventArgs e) {
            Person p = null;
            try
            {
                // Create new person and display information.
                p = new Person(this.firstNameBox.Text, this.lastNameBox.Text, this.persNrBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid persnr");
                return;
            }

            this.infoBox.Text = p.ToString();
        }
    }
}