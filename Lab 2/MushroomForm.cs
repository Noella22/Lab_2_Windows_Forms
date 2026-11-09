
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class MushroomForm : Form
    {
        int question = 1;
        string forest = "";
        string convex = "";

        public MushroomForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChooseForm choose = new ChooseForm();
            choose.Show();
            this.Hide();
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (question == 1)
            {
                forest = "yes";
                lblQuestion.Text = "Does your mushroom have a convex cap?";
                question = 2;
            }
            else if (question == 2)
            {
                convex = "yes";

                if (forest == "yes")
                {
                    lblQuestion.Text = "Does your mushroom have a ring?";
                    question = 3;
                }
                else
                {
                    lblQuestion.Text = "Your mushroom is Agaric Jaunissant";
                    question = 4;
                }
            }
            else if (question == 3)
            {
                if (convex == "yes")
                {
                    lblQuestion.Text = "Your mushroom is Amanite tue-mouche";
                }
                else
                {
                    lblQuestion.Text = "Your mushroom is Girolle";
                }

                question = 4;
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (question == 1)
            {
                forest = "no";
                lblQuestion.Text = "Does your mushroom have a convex cap?";
                question = 2;
            }
            else if (question == 2)
            {
                convex = "no";

                if (forest == "yes")
                {
                    lblQuestion.Text = "Does your mushroom have gills?";
                    question = 3;
                }
                else
                {
                    lblQuestion.Text = "Your mushroom is Coprin chevelu";
                    question = 4;
                }
            }
            else if (question == 3)
            {
                if (convex == "yes")
                {
                    lblQuestion.Text = "Your mushroom is Pied bleu";
                }
                else
                {
                    lblQuestion.Text = "Your mushroom is Cepe de Bordeaux";
                }

                question = 4;
            }
        }

        private void MushroomForm_Load(object sender, EventArgs e)
        {

        }
    }
}
