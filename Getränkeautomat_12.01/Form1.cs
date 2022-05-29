using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Getränkeautomat_12._01
{
    public partial class Form1 : Form
    {       
        double Guthaben = 0.00;
        public Form1()
        {
            InitializeComponent();
        } 
        public void EuroEinButton_Click(object sender, EventArgs e)
        {
          Guthaben = Convert.ToDouble(GeldausgabeTextB.Text) + 1;
            GeldausgabeTextB.Text = Convert.ToString(Guthaben);
            
        }

        public void EuroZweiButton_Click(object sender, EventArgs e)
        {
            Guthaben = Convert.ToDouble(GeldausgabeTextB.Text) + 2;
            GeldausgabeTextB.Text = Convert.ToString(Guthaben);
        }

        public void MoneyButton3_Click(object sender, EventArgs e)
        {
            Guthaben = Convert.ToDouble(GeldausgabeTextB.Text) + 0.5;
            GeldausgabeTextB.Text = Convert.ToString(Guthaben);
        }
        private void Bn_GeldBack_Click(object sender, EventArgs e)
        {
            Guthaben = Convert.ToDouble(GeldausgabeTextB.Text) * 0;
            GeldausgabeTextB.Text = Convert.ToString(Guthaben);
        }

        public void  GetränkeButton_Click(object sender, EventArgs e)
        {
            double Mindesteinzahlung = 2; //Mindesteinzahlung = Minimum deposit

            
            if (Convert.ToDouble(GeldausgabeTextB.Text) >= Mindesteinzahlung) 
            {                               
                {
                    Guthaben = Convert.ToDouble(GeldausgabeTextB.Text) - 2;    
                    String Restgeld = ($"Ihr Restgeld Beträgt {Guthaben}");
                    GeldausgabeTextB.Text = Convert.ToString(Restgeld);
                    
                }
           

            }
            else if (Convert.ToDouble(GeldausgabeTextB.Text) < Mindesteinzahlung)
            {
               double a = Convert.ToDouble(GeldausgabeTextB.Text);
                GeldausgabeTextB.Text = ("Sie müssen Geld einzahlen");  // Sie müssen Geldeinzahlen = You need to deposit money
            }
        }
    }
}

//CC:Eaven René Schmalz