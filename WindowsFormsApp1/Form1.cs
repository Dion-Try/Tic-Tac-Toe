using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   
    public partial class Form1 : Form
    {

        Spieler x = new Spieler("X");
        Spieler o = new Spieler("O");
        
        public void aktivSetzen()
        {
            if (x.aktiv)
            {
                x.aktiv = false;
                o.aktiv = true;
            }
            else
            {
                o.aktiv = false;
                x.aktiv = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
            x.aktiv = true;
        }

        private void obnLnksBtn_Click(object sender, EventArgs e)
        {
            if (x.aktiv)
            {
                obnLnksBtn.Text = x.name;
                aktivSetzen();
            }
            else
            {
                obnLnksBtn.Text = o.name;
                aktivSetzen();
            }
            obnLnksBtn.Enabled = false;
            fallsGewonnen();
        }

        private void obnMitteBtn_Click(object sender, EventArgs e)
        {
            if (x.aktiv)
            {
                obnMitteBtn.Text = x.name;
                aktivSetzen();
            }
            else
            {
                obnMitteBtn.Text = o.name;
                aktivSetzen();
            }
            obnMitteBtn.Enabled = false;
            fallsGewonnen();
        }

        private void obnRechtsBtn_Click(object sender, EventArgs e)
        {
                if (x.aktiv)
                {
                    obnRechtsBtn.Text = x.name;
                    aktivSetzen();
                }
                else
                {
                    obnRechtsBtn.Text = o.name;
                    aktivSetzen();
                }
            obnRechtsBtn.Enabled = false;
            fallsGewonnen();
        }

        private void mittLnksBtn_Click(object sender, EventArgs e)
        {
            if (x.aktiv)
            {
                mittLnksBtn.Text = x.name;
                aktivSetzen();
            }
            else
            {
                mittLnksBtn.Text = o.name;
                aktivSetzen();
            }
            mittLnksBtn.Enabled = false;
            fallsGewonnen();
        }

        private void mitteBtn_Click(object sender, EventArgs e)
        {
            if (x.aktiv)
            {
                mitteBtn.Text = x.name;
                aktivSetzen();
            }
            else
            {
                mitteBtn.Text = o.name;
                aktivSetzen();
            }
            mitteBtn.Enabled = false;
            fallsGewonnen();
        }

        private void mittRechtsBtn_Click(object sender, EventArgs e)
        {
            if (x.aktiv)
            {
                mittRechtsBtn.Text = x.name;
                aktivSetzen();
            }
            else
            {
                mittRechtsBtn.Text = o.name;
                aktivSetzen();
            }
            fallsGewonnen();
            mittRechtsBtn.Enabled = false;
        }

        private void untnLinksBtn_Click(object sender, EventArgs e)
        {
            if (x.aktiv)
            {
                untnLinksBtn.Text = x.name;
                aktivSetzen();
            }
            else
            {
                untnLinksBtn.Text = o.name;
                aktivSetzen();
            }
            untnLinksBtn.Enabled = false;
            fallsGewonnen();
        }

        private void untenMitteBtn_Click(object sender, EventArgs e)
        {
            if (x.aktiv)
            {
                untenMitteBtn.Text = x.name;
                aktivSetzen();
            }
            else
            {
                untenMitteBtn.Text = o.name;
                aktivSetzen();
            }
            untenMitteBtn.Enabled = false;
            fallsGewonnen();
        }

        private void untenRechtsBtn_Click(object sender, EventArgs e)
        {
            if (x.aktiv)
            {
                untenRechtsBtn.Text = x.name;
                aktivSetzen();
                
            }
            else
            {
                untenRechtsBtn.Text = o.name;
                aktivSetzen();

            }
            untenRechtsBtn.Enabled = false;
            fallsGewonnen();
        }

        private void fallsGewonnen()
        {
            // oben waagrecht
            if (obnLnksBtn.Text == "X" && obnMitteBtn.Text =="X" && obnRechtsBtn.Text == "X")
            {
                labelText(0);
            }
            else if (obnLnksBtn.Text == "O" && obnMitteBtn.Text == "O" && obnRechtsBtn.Text == "O")
            {
                labelText(1);
            }
            // mitte waagrecht
            else if (mittLnksBtn.Text == "X" && mitteBtn.Text == "X" && mittRechtsBtn.Text == "X")
            {
                labelText(0);
            }
            else if (mittLnksBtn.Text == "O" && mitteBtn.Text == "O" && mittRechtsBtn.Text == "O")
            {
                labelText(1);
            }
            // unten waagrecht
            else if (untnLinksBtn.Text == "X" && untenMitteBtn.Text == "X" && untenRechtsBtn.Text == "X")
            {
                labelText(0);
            }
            else if (untnLinksBtn.Text == "O" && untenMitteBtn.Text == "O" && untenRechtsBtn.Text == "O")
            {
                labelText(1);
            }
            // links vertikal
            else if (obnLnksBtn.Text == "X" && mittLnksBtn.Text == "X" && untnLinksBtn.Text == "X")
            {
                labelText(0);
            }
            else if (obnLnksBtn.Text == "O" && mittLnksBtn.Text == "O" && untnLinksBtn.Text == "O")
            {
                labelText(1);
            }
            // mitte vertikal
            else if (obnMitteBtn.Text == "X" && mitteBtn.Text == "X" && untenMitteBtn.Text == "X")
            {
                labelText(0);
            }
            else if (obnMitteBtn.Text == "O" && mitteBtn.Text == "O" && untenMitteBtn.Text == "O")
            {
                labelText(1);
            }
            // rechts vertikal
            else if (obnRechtsBtn.Text == "X" && mittRechtsBtn.Text == "X" && untenRechtsBtn.Text == "X")
            {
                labelText(0);
            }
            else if (obnRechtsBtn.Text == "O" && mittRechtsBtn.Text == "O" && untenRechtsBtn.Text == "O")
            {
                labelText(1);
            }
            // Links nach rechts diagonal
            else if (obnLnksBtn.Text == "X" && mitteBtn.Text == "X" && untenRechtsBtn.Text == "X")
            {
                labelText(0);
            }
            else if (obnLnksBtn.Text == "O" && mitteBtn.Text == "O" && untenRechtsBtn.Text == "O")
            {
                labelText(1);
            }
            // Recths nach links diagonal
            else if (obnRechtsBtn.Text == "X" && mitteBtn.Text == "X" && untnLinksBtn.Text == "X")
            {
                labelText(0);
            }
            else if (obnRechtsBtn.Text == "O" && mitteBtn.Text == "O" && untnLinksBtn.Text == "O")
            {
                labelText(1);
            }
            else if(obnLnksBtn.Enabled == false && obnMitteBtn.Enabled == false && obnRechtsBtn.Enabled == false && mittLnksBtn.Enabled == false && mitteBtn.Enabled == false && mittRechtsBtn.Enabled == false && untnLinksBtn.Enabled == false && untenMitteBtn.Enabled == false && untenRechtsBtn.Enabled == false)
            {
                labelText(2);
            }
        }
        public void labelText(int resultat)
        {
            switch (resultat)
            {
                // 0 = x hat gewonnen
                case 0:
                    label.Text = "Spieler x hat Spieler O zerstört";
                    break;
                // 1 = o hat gewonnen
                case 1:
                    label.Text = "Spieler O hat Spieler X zerstört";
                    break;
                // 2 = unentschieden
                case 2:
                    label.Text = "Unentschieden";
                    break;
            }
            obnLnksBtn.Enabled = false;
            obnMitteBtn.Enabled = false;
            obnRechtsBtn.Enabled = false;
            mittLnksBtn.Enabled = false;
            mitteBtn.Enabled = false;
            mittRechtsBtn.Enabled = false;
            untnLinksBtn.Enabled = false;
            untenMitteBtn.Enabled = false;
            untenRechtsBtn.Enabled = false;


        }

        private void neustart_Click(object sender, EventArgs e)
        {
            obnLnksBtn.Enabled = true;
            obnMitteBtn.Enabled = true;
            obnRechtsBtn.Enabled = true;
            mittLnksBtn.Enabled = true;
            mitteBtn.Enabled = true;
            mittRechtsBtn.Enabled = true;
            untnLinksBtn.Enabled = true;
            untenMitteBtn.Enabled = true;
            untenRechtsBtn.Enabled = true;

            obnLnksBtn.Text = "";
            obnMitteBtn.Text = "";
            obnRechtsBtn.Text = "";
            mittLnksBtn.Text = "";
            mitteBtn.Text = "";
            mittRechtsBtn.Text = "";
            untnLinksBtn.Text = "";
            untenMitteBtn.Text = "";
            untenRechtsBtn.Text = "";

            label.Text = "";

            aktivSetzen();


        }
    }

    public class Spieler
    {
        public string name;

        public bool aktiv = false;

        public Spieler(string name)
        {
            this.name = name;
        }
    }
}
