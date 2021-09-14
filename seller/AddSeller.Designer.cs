
namespace seller
{
    partial class AddSeller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.persnrLabel = new System.Windows.Forms.Label();
            this.districtLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.persnrBox = new System.Windows.Forms.TextBox();
            this.districtBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(78, 29);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // persnrLabel
            // 
            this.persnrLabel.AutoSize = true;
            this.persnrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persnrLabel.Location = new System.Drawing.Point(13, 79);
            this.persnrLabel.Name = "persnrLabel";
            this.persnrLabel.Size = new System.Drawing.Size(84, 29);
            this.persnrLabel.TabIndex = 1;
            this.persnrLabel.Text = "Persnr";
            // 
            // districtLabel
            // 
            this.districtLabel.AutoSize = true;
            this.districtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtLabel.Location = new System.Drawing.Point(13, 145);
            this.districtLabel.Name = "districtLabel";
            this.districtLabel.Size = new System.Drawing.Size(86, 29);
            this.districtLabel.TabIndex = 2;
            this.districtLabel.Text = "District";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 45);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(270, 20);
            this.nameBox.TabIndex = 3;
            // 
            // persnrBox
            // 
            this.persnrBox.Location = new System.Drawing.Point(12, 111);
            this.persnrBox.Name = "persnrBox";
            this.persnrBox.Size = new System.Drawing.Size(270, 20);
            this.persnrBox.TabIndex = 4;
            // 
            // districtBox
            // 
            this.districtBox.Location = new System.Drawing.Point(12, 177);
            this.districtBox.Name = "districtBox";
            this.districtBox.Size = new System.Drawing.Size(270, 20);
            this.districtBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(94, 312);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(188, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(13, 312);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(12, 238);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(270, 20);
            this.amountBox.TabIndex = 9;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(13, 206);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(94, 29);
            this.amountLabel.TabIndex = 8;
            this.amountLabel.Text = "Amount";
            // 
            // AddSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 347);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.districtBox);
            this.Controls.Add(this.persnrBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.districtLabel);
            this.Controls.Add(this.persnrLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddSeller";
            this.Text = "AddSeller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label persnrLabel;
        private System.Windows.Forms.Label districtLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox persnrBox;
        private System.Windows.Forms.TextBox districtBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label amountLabel;
    }
}