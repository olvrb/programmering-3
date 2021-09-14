using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Oliver Boudet 0204150072 L0002B
namespace change_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            CollectionOfMoney change = new CollectionOfMoney();

            // Declare all types of possible bills & coins
            Money[] possibilities = {
                new Money(1000),
                new Money(500),
                new Money(200),
                new Money(100),
                new Money(50),
                new Money(20),
                new Money(10),
                new Money(5),
                new Money(2),
                new Money(1)
            };

            int calc = 0;
            while (calc <= 0)
            {
                // Get price and paid amount.
                int price = GetIntFromTextBox(priceBox);
                int paid = GetIntFromTextBox(paidBox);


                // -1 means no valid number was entered.
                if (price == -1 || paid == -1) return;

                calc = paid - price;

                if (calc < 0)
                {
                     MessageBox.Show("Not enough money :(. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            // Add one or more bills/coins of every relevant type to the money collection.
            foreach (var m in possibilities)
            {
                while (calc >= m.Type)
                {
                    m.Amount++;
                    calc -= m.Type;
                }

                change.AddMoney(m);
            }

            // Iterate through every type of money and print how many of each bills/coins the customer is to get back.
            foreach (var money in change.Moneys)
            {
                if (money.Amount != 0)
                {
                    resultBox.AppendText($"{money.Amount} {money.GetHumanName()}\n");
                }
            }

            resultBox.AppendText($"Total is {change.Sum()}kr");
        }

        public static int GetIntFromTextBox(TextBox box)
        {

            // Keep asking for a number until get a valid number. -1 is just a placeholder
            int i = -1;
            
            try
            {
                i = int.Parse(box.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            return i;
        }
    }
}
