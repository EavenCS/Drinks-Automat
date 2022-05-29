
namespace Getränkeautomat_12._01
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ColaButton = new System.Windows.Forms.Button();
            this.Spritebutton = new System.Windows.Forms.Button();
            this.LimoButton = new System.Windows.Forms.Button();
            this.WaterButton = new System.Windows.Forms.Button();
            this.EuroEinButton = new System.Windows.Forms.Button();
            this.Cent50Button = new System.Windows.Forms.Button();
            this.EuroZweiButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.GeldausgabeTextB = new System.Windows.Forms.TextBox();
            this.GeldBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ColaButton
            // 
            this.ColaButton.Location = new System.Drawing.Point(29, 43);
            this.ColaButton.Name = "ColaButton";
            this.ColaButton.Size = new System.Drawing.Size(89, 77);
            this.ColaButton.TabIndex = 1;
            this.ColaButton.Text = "Cola";
            this.ColaButton.UseVisualStyleBackColor = true;
            this.ColaButton.Click += new System.EventHandler(this.GetränkeButton_Click);
            // 
            // Spritebutton
            // 
            this.Spritebutton.Location = new System.Drawing.Point(161, 167);
            this.Spritebutton.Name = "Spritebutton";
            this.Spritebutton.Size = new System.Drawing.Size(87, 75);
            this.Spritebutton.TabIndex = 2;
            this.Spritebutton.Text = "Sprite";
            this.Spritebutton.UseVisualStyleBackColor = true;
            this.Spritebutton.Click += new System.EventHandler(this.GetränkeButton_Click);
            // 
            // LimoButton
            // 
            this.LimoButton.Location = new System.Drawing.Point(29, 167);
            this.LimoButton.Name = "LimoButton";
            this.LimoButton.Size = new System.Drawing.Size(89, 75);
            this.LimoButton.TabIndex = 3;
            this.LimoButton.Text = "Limo";
            this.LimoButton.UseVisualStyleBackColor = true;
            this.LimoButton.Click += new System.EventHandler(this.GetränkeButton_Click);
            // 
            // WaterButton
            // 
            this.WaterButton.Location = new System.Drawing.Point(161, 43);
            this.WaterButton.Name = "WaterButton";
            this.WaterButton.Size = new System.Drawing.Size(87, 77);
            this.WaterButton.TabIndex = 4;
            this.WaterButton.Text = "Water";
            this.WaterButton.UseVisualStyleBackColor = true;
            this.WaterButton.Click += new System.EventHandler(this.GetränkeButton_Click);
            // 
            // EuroEinButton
            // 
            this.EuroEinButton.Location = new System.Drawing.Point(412, 81);
            this.EuroEinButton.Name = "EuroEinButton";
            this.EuroEinButton.Size = new System.Drawing.Size(75, 61);
            this.EuroEinButton.TabIndex = 9;
            this.EuroEinButton.Text = "1Euro";
            this.EuroEinButton.UseVisualStyleBackColor = true;
            this.EuroEinButton.Click += new System.EventHandler(this.EuroEinButton_Click);
            // 
            // Cent50Button
            // 
            this.Cent50Button.Location = new System.Drawing.Point(412, 148);
            this.Cent50Button.Name = "Cent50Button";
            this.Cent50Button.Size = new System.Drawing.Size(75, 64);
            this.Cent50Button.TabIndex = 11;
            this.Cent50Button.Text = "50ct";
            this.Cent50Button.UseVisualStyleBackColor = true;
            this.Cent50Button.Click += new System.EventHandler(this.MoneyButton3_Click);
            // 
            // EuroZweiButton
            // 
            this.EuroZweiButton.Location = new System.Drawing.Point(493, 81);
            this.EuroZweiButton.Name = "EuroZweiButton";
            this.EuroZweiButton.Size = new System.Drawing.Size(75, 62);
            this.EuroZweiButton.TabIndex = 12;
            this.EuroZweiButton.Text = "2Euro";
            this.EuroZweiButton.UseVisualStyleBackColor = true;
            this.EuroZweiButton.Click += new System.EventHandler(this.EuroZweiButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(281, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(104, 199);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "Preisliste:\nCola Kostet     1€\nSprite Kostet   1€\nLimo Kostet    1€\nWasser Kostet" +
    " 1€";
            // 
            // GeldausgabeTextB
            // 
            this.GeldausgabeTextB.Cursor = System.Windows.Forms.Cursors.No;
            this.GeldausgabeTextB.Location = new System.Drawing.Point(413, 43);
            this.GeldausgabeTextB.Name = "GeldausgabeTextB";
            this.GeldausgabeTextB.Size = new System.Drawing.Size(155, 20);
            this.GeldausgabeTextB.TabIndex = 14;
            this.GeldausgabeTextB.Text = "0";
            this.GeldausgabeTextB.ModifiedChanged += new System.EventHandler(this.EuroEinButton_Click);
            // 
            // GeldBackButton
            // 
            this.GeldBackButton.Location = new System.Drawing.Point(493, 149);
            this.GeldBackButton.Name = "GeldBackButton";
            this.GeldBackButton.Size = new System.Drawing.Size(75, 23);
            this.GeldBackButton.TabIndex = 15;
            this.GeldBackButton.Text = "Geld zurück ";
            this.GeldBackButton.UseVisualStyleBackColor = true;
            this.GeldBackButton.Click += new System.EventHandler(this.Bn_GeldBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(580, 283);
            this.Controls.Add(this.GeldBackButton);
            this.Controls.Add(this.GeldausgabeTextB);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.EuroZweiButton);
            this.Controls.Add(this.Cent50Button);
            this.Controls.Add(this.EuroEinButton);
            this.Controls.Add(this.WaterButton);
            this.Controls.Add(this.LimoButton);
            this.Controls.Add(this.Spritebutton);
            this.Controls.Add(this.ColaButton);
            this.Name = "Form1";
            this.Text = "Getränkeautomat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ColaButton;
        private System.Windows.Forms.Button Spritebutton;
        private System.Windows.Forms.Button LimoButton;
        private System.Windows.Forms.Button WaterButton;
        private System.Windows.Forms.Button EuroEinButton;
        private System.Windows.Forms.Button Cent50Button;
        private System.Windows.Forms.Button EuroZweiButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox GeldausgabeTextB;
        private System.Windows.Forms.Button GeldBackButton;
    }
}

