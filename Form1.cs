using System .Drawing;
using System .Windows .Forms;

namespace codecouleur
{
    public partial class Form1 : Form
    {
        // valeur calcul
        double tolerance;
        // valeur anneau numeric
        int valeur1;
        int valeur2;
        double valeur3;
        double valeur4;
        // valeur anneau string
        string valeuranstr1;
        string valeuranstr2;
        string valeuranstr3;
        string valeuranstr4;
        double valeurresist;
        double valeurresite1;
        double valeurresite2;

        public Form1() { InitializeComponent(); }




        private void button2_Click(object sender , System .EventArgs e)
        {
            //
            // calcul resultat
            //
            valeurresist = ((valeur1 + 10) + valeur2) * valeur3;
            textBox1 .Text = valeurresist .ToString();
            //
            //si resitance en ohms,kohm,m ohms
            //
            if (valeurresist <= 999)
            {
                label22 .Text = "ohms";
                label29 .Text = "ohms";
            }
            if (valeurresist >= 1000 && valeurresist <= 999999)
            {
                label22 .Text = "k ohms";
                label29 .Text = "k ohms";
            }
            if (valeurresist >= 1000000 && valeurresist <= 99999999)
            {
                label22 .Text = "m ohms";
                label29 .Text = "m ohms";
            }

            //
            //calcul tolérance
            //
            tolerance = (valeurresist * valeur4) / 100;
            textBox2 .Text = tolerance .ToString();
            //
            // calcul résistance avec tolérance +-
            //
            valeurresite1 = valeurresist - tolerance;
            valeurresite2 = valeurresist + tolerance;
            //
            //affichage
            //
            textBox3 .Text = valeurresite1 .ToString();
            textBox4 .Text = valeurresite2 .ToString();

        }

        private void button1_Click(object sender , System .EventArgs e)
        {
            valeuranstr1 = comboBox1 .Text;
            valeuranstr2 = comboBox2 .Text;
            valeuranstr3 = comboBox3 .Text;
            valeuranstr4 = comboBox4 .Text;

            //valeur des couleur anneaux
            //
            //couleur anneau1
            //


            if (valeuranstr1 == "noir")

            {
                label10 .BackColor = Color .Black;
                valeur1 = 0;
            }
            if ((valeuranstr1 == "marron"))

            {
                valeur1 = 1;
                label10 .BackColor = Color .Brown;
            }
            if ((valeuranstr1 == "rouge"))

            {
                valeur1 = 2;
                label10 .BackColor = Color .Red;
            }
            if ((valeuranstr1 == "orange"))

            {
                valeur1 = 3;
                label10 .BackColor = Color .Orange;
            }
            if ((valeuranstr1 == "jaune"))

            {
                valeur1 = 4;
                label10 .BackColor = Color .Yellow;
            }
            if ((valeuranstr1 == "vert"))

            {
                valeur1 = 5;
                label10 .BackColor = Color .Green;
            }
            if ((valeuranstr1 == "bleu"))

            {
                valeur1 = 6;
                label10 .BackColor = Color .Blue;
            }
            if ((valeuranstr1 == "violet"))

            {
                valeur1 = 7;
                label10 .BackColor = Color .Violet;
            }
            if ((valeuranstr1 == "gris"))

            {
                valeur1 = 8;
                label10 .BackColor = Color .Gray;
            }
            if ((valeuranstr1 == "blanc"))

            {
                valeur1 = 9;
                label10 .BackColor = Color .White;
            }



            //
            //couleur anneau2
            //

            if (valeuranstr2 == "noir")

            {
                label12 .BackColor = Color .Black;
                valeur2 = 0;
            }
            if ((valeuranstr2 == "marron"))

            {
                valeur2 = 1;
                label12 .BackColor = Color .Brown;
            }
            if ((valeuranstr2 == "rouge"))

            {
                valeur2 = 2;
                label12 .BackColor = Color .Red;
            }
            if ((valeuranstr2 == "orange"))

            {
                valeur2 = 3;
                label12 .BackColor = Color .Orange;
            }
            if ((valeuranstr2 == "jaune"))

            {
                valeur2 = 4;
                label12 .BackColor = Color .Yellow;
            }
            if ((valeuranstr2 == "vert"))

            {
                valeur2 = 5;
                label12 .BackColor = Color .Green;
            }
            if ((valeuranstr2 == "bleu"))

            {
                valeur2 = 6;
                label12 .BackColor = Color .Blue;
            }
            if ((valeuranstr2 == "violet"))

            {
                valeur2 = 7;
                label12 .BackColor = Color .Violet;
            }
            if ((valeuranstr2 == "gris"))

            {
                valeur2 = 8;
                label12 .BackColor = Color .Gray;
            }
            if ((valeuranstr2 == "blanc"))

            {
                valeur2 = 9;
                label12 .BackColor = Color .White;
            }
            //
            //couleur anneau3
            //
            if (valeuranstr3 == "noir")

            {
                label15 .BackColor = Color .Black;
                valeur3 = 1;
            }
            if ((valeuranstr3 == "marron"))

            {
                valeur3 = 10;
                label15 .BackColor = Color .Brown;
            }
            if ((valeuranstr3 == "rouge"))

            {
                valeur3 = 100;
                label15 .BackColor = Color .Red;
            }
            if ((valeuranstr3 == "orange"))

            {
                valeur3 = 1000;
                label15 .BackColor = Color .Orange;
            }
            if ((valeuranstr3 == "jaune"))

            {
                valeur3 = 10000;
                label5 .BackColor = Color .Yellow;
            }
            if ((valeuranstr3 == "vert"))

            {
                valeur3 = 100000;
                label15 .BackColor = Color .Green;
            }
            if ((valeuranstr3 == "bleu"))

            {
                valeur3 = 1000000;
                label15 .BackColor = Color .Blue;
            }
            if ((valeuranstr3 == "violet"))

            {
                valeur3 = 10000000;
                label15 .BackColor = Color .Violet;
            }
            if ((valeuranstr3 == "or"))

            {
                valeur3 = 0.1;
                label15 .BackColor = Color .Gold;
            }
            if ((valeuranstr3 == "argent"))

            {
                valeur3 = 0.01;
                label15 .BackColor = Color .Silver;
            }
            //
            //couleur anneau4
            //


            if ((valeuranstr4 == "marron"))

            {
                valeur4 = 1;
                label17 .BackColor = Color .Brown;
            }
            else if ((valeuranstr4 == "rouge"))

            {
                valeur4 = 2;
                label17 .BackColor = Color .Red;
            }
            else if ((valeuranstr4 == "vert"))

            {
                valeur4 = 0.5;
                label17 .BackColor = Color .Green;
            }
            else if ((valeuranstr4 == "bleu"))

            {
                valeur4 = 0.25;
                label17 .BackColor = Color .Blue;
            }
            else if ((valeuranstr4 == "violet"))

            {
                valeur4 = 0.1;
                label17 .BackColor = Color .Violet;
            }
            else if ((valeuranstr4 == "gris"))

            {
                valeur4 = 0.05;
                label17 .BackColor = Color .Gray;
            }
            else if ((valeuranstr4 == "or"))

            {
                valeur4 = 5;
                label17 .BackColor = Color .Gold;
            }
            else if ((valeuranstr4 == "argent"))

            {
                valeur4 = 10;
                label17 .BackColor = Color .Silver;
            }

        }
    }
}













