namespace seller
{
  partial class Main
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
    private void InitializeComponent() {
            this.addUserButton = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // addUserButton
            // 
            this.addUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserButton.Location = new System.Drawing.Point(245, 542);
            this.addUserButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(95, 27);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Add seller";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(4, 4);
            this.infoBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(575, 525);
            this.infoBox.TabIndex = 2;
            this.infoBox.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 579);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.addUserButton);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

    }

        #endregion
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.RichTextBox infoBox;
    }
}

