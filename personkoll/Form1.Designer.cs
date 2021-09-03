
namespace personkoll
{
    partial class Form1
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
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.persNrBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.infoBox = new System.Windows.Forms.RichTextBox();
            this.processButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(13, 30);
            this.firstNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(132, 22);
            this.firstNameBox.TabIndex = 0;
            // 
            // persNrBox
            // 
            this.persNrBox.Location = new System.Drawing.Point(17, 133);
            this.persNrBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.persNrBox.Name = "persNrBox";
            this.persNrBox.Size = new System.Drawing.Size(132, 22);
            this.persNrBox.TabIndex = 1;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(13, 86);
            this.lastNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(132, 22);
            this.lastNameBox.TabIndex = 2;
            // 
            // infoBox
            // 
            this.infoBox.Enabled = false;
            this.infoBox.Location = new System.Drawing.Point(17, 281);
            this.infoBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(1032, 258);
            this.infoBox.TabIndex = 3;
            this.infoBox.Text = "";
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(15, 163);
            this.processButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(100, 28);
            this.processButton.TabIndex = 4;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Persnr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.persNrBox);
            this.Controls.Add(this.firstNameBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox persNrBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.RichTextBox infoBox;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

