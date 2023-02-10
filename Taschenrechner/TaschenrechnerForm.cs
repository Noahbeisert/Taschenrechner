using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{

    public partial class TaschenrechnerForm : Form
    {
        string letzteOperation = null;
        double? letzeZahl = null;
        bool textHatErgebnis = false;
        public TaschenrechnerForm()
        {
            InitializeComponent();
        }
        private void OperatorButton(string Op)
        {
            if (this.textFuerZahlen.Text == "")
            {

            }
            else
            {
                if (this.letzeZahl != null)
                {
                    this.gleichzeichen_Click(null, null);
                }
                this.letzeZahl = Convert.ToDouble(this.textFuerZahlen.Text);
                this.textFuerZahlen.Text = "";
                this.textFuerZwischenErgebnis.Text = Convert.ToString(letzeZahl) + " " + Op;
                this.letzteOperation = Op;
            }

        }


        private void zahl_Click(string zahl)
        {
            if (this.textHatErgebnis == true)
            {
                if (this.textFuerZahlen.Text != "")
                {
                    this.letzeZahl = Convert.ToDouble(this.textFuerZahlen.Text);
                }
                this.textFuerZahlen.Text = "";
                this.textHatErgebnis = false;
            }
            this.textFuerZahlen.Text = this.textFuerZahlen.Text + zahl;
        }

        private void zahl1_Click(object sender, EventArgs e)
        {
            this.zahl_Click("1");
        }

        private void zahl2_Click(object sender, EventArgs e)
        {
            this.zahl_Click("2");
        }

        private void zahl3_Click(object sender, EventArgs e)
        {
            this.zahl_Click("3");
        }

        private void zahl4_Click(object sender, EventArgs e)
        {
            this.zahl_Click("4");
        }

        private void zahl5_Click(object sender, EventArgs e)
        {
            this.zahl_Click("5"); ;
        }

        private void zahl6_Click(object sender, EventArgs e)
        {
            this.zahl_Click("6");
        }

        private void zahl7_Click(object sender, EventArgs e)
        {
            this.zahl_Click("7");
        }

        private void zahl8_Click(object sender, EventArgs e)
        {
            this.zahl_Click("8");
        }

        private void zahl9_Click(object sender, EventArgs e)
        {
            this.zahl_Click("9");
        }

        private void zahl0_Click(object sender, EventArgs e)
        {
            this.zahl_Click("0");
        }



        private void minuszeichen_Click(object sender, EventArgs e)
        {
            this.OperatorButton("-");
        }

        private void gleichzeichen_Click(object sender, EventArgs e)
        {
            if (this.textFuerZahlen.Text == "")
            {
                return;
            }
            double? zahlvonText = Convert.ToDouble(this.textFuerZahlen.Text);
            if (this.letzteOperation == "+")
            {
                double? ErgebnisPlus = letzeZahl + zahlvonText;
                this.textFuerZahlen.Text = ErgebnisPlus.ToString();
            }
            else if (this.letzteOperation == "-")
            {
                double? ErgebnisMinus = (letzeZahl - zahlvonText);
                this.textFuerZahlen.Text = ErgebnisMinus.ToString();
            }
            else if (this.letzteOperation == "*")
            {
                double? ErgebnisMal = (letzeZahl * zahlvonText);
                this.textFuerZahlen.Text = ErgebnisMal.ToString();
            }
            else if (this.letzteOperation == "/")
            {
                double? ErgebnisGeteilt = (letzeZahl + zahlvonText);
                this.textFuerZahlen.Text = ErgebnisGeteilt.ToString();
            }
            this.letzeZahl = null;
            this.letzteOperation = null;
            this.textHatErgebnis = true;
            this.textFuerZwischenErgebnis.Text = this.textFuerZahlen.Text;

        }

        private void pluszeichen_Click(object sender, EventArgs e)
        {
            this.OperatorButton("+");
        }

        private void geteiltzeichen_Click(object sender, EventArgs e)
        {
            this.OperatorButton("/");
        }

        private void malzeichen_Click(object sender, EventArgs e)
        {
            this.OperatorButton("*");
        }

        private void resetknopf_Click(object sender, EventArgs e)
        {
            this.textFuerZahlen.Text = "";
            this.textFuerZwischenErgebnis.Text = "";
            this.letzeZahl = null;
            this.letzteOperation = null;
        }
    }
}
