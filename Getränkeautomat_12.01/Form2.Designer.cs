
namespace Getränkeautomat_12._01
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.Geld10Ct = new System.Windows.Forms.Button();
            this.Geld100Ct = new System.Windows.Forms.Button();
            this.Geld20Ct = new System.Windows.Forms.Button();
            this.TextBoxGeldbetrag = new System.Windows.Forms.TextBox();
            this.Geld200ct = new System.Windows.Forms.Button();
            this.bGeldauswurf = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // Geld10Ct
            // 
            this.Geld10Ct.Location = new System.Drawing.Point(64, 86);
            this.Geld10Ct.Name = "Geld10Ct";
            this.Geld10Ct.Size = new System.Drawing.Size(75, 23);
            this.Geld10Ct.TabIndex = 0;
            this.Geld10Ct.Text = "0.10€";
            this.Geld10Ct.UseVisualStyleBackColor = true;
            this.Geld10Ct.Click += new System.EventHandler(this.Geld10Ct_Click);
            // 
            // Geld100Ct
            // 
            this.Geld100Ct.Location = new System.Drawing.Point(163, 86);
            this.Geld100Ct.Name = "Geld100Ct";
            this.Geld100Ct.Size = new System.Drawing.Size(75, 23);
            this.Geld100Ct.TabIndex = 1;
            this.Geld100Ct.Text = "1€";
            this.Geld100Ct.UseVisualStyleBackColor = true;
            this.Geld100Ct.Click += new System.EventHandler(this.Geld100Ct_Click);
            // 
            // Geld20Ct
            // 
            this.Geld20Ct.Location = new System.Drawing.Point(64, 132);
            this.Geld20Ct.Name = "Geld20Ct";
            this.Geld20Ct.Size = new System.Drawing.Size(75, 23);
            this.Geld20Ct.TabIndex = 3;
            this.Geld20Ct.Text = "0.20€";
            this.Geld20Ct.UseVisualStyleBackColor = true;
            this.Geld20Ct.Click += new System.EventHandler(this.Geld20Ct_Click);
            // 
            // TextBoxGeldbetrag
            // 
            this.TextBoxGeldbetrag.Location = new System.Drawing.Point(102, 60);
            this.TextBoxGeldbetrag.Name = "TextBoxGeldbetrag";
            this.TextBoxGeldbetrag.Size = new System.Drawing.Size(97, 20);
            this.TextBoxGeldbetrag.TabIndex = 4;
            this.TextBoxGeldbetrag.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Geld200ct
            // 
            this.Geld200ct.Location = new System.Drawing.Point(163, 132);
            this.Geld200ct.Name = "Geld200ct";
            this.Geld200ct.Size = new System.Drawing.Size(75, 23);
            this.Geld200ct.TabIndex = 5;
            this.Geld200ct.Text = "2€";
            this.Geld200ct.UseVisualStyleBackColor = true;
            this.Geld200ct.Click += new System.EventHandler(this.Geld200ct_Click);
            // 
            // bGeldauswurf
            // 
            this.bGeldauswurf.Location = new System.Drawing.Point(102, 161);
            this.bGeldauswurf.Name = "bGeldauswurf";
            this.bGeldauswurf.Size = new System.Drawing.Size(75, 23);
            this.bGeldauswurf.TabIndex = 7;
            this.bGeldauswurf.Text = "Geldauswurf";
            this.bGeldauswurf.UseVisualStyleBackColor = true;
            this.bGeldauswurf.Click += new System.EventHandler(this.bGeldauswurf_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 272);
            this.Controls.Add(this.bGeldauswurf);
            this.Controls.Add(this.Geld200ct);
            this.Controls.Add(this.TextBoxGeldbetrag);
            this.Controls.Add(this.Geld20Ct);
            this.Controls.Add(this.Geld100Ct);
            this.Controls.Add(this.Geld10Ct);
            this.Name = "Form2";
            this.Text = "Geldeinwurf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Geld10Ct;
        private System.Windows.Forms.Button Geld100Ct;
        private System.Windows.Forms.Button Geld20Ct;
        private System.Windows.Forms.TextBox TextBoxGeldbetrag;
        private System.Windows.Forms.Button Geld200ct;
        private System.Windows.Forms.Button bGeldauswurf;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}