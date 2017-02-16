using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCaseApp
{
    public partial class Form1 : Form
    {
        List<UsecaseActor> actorList = new List<UsecaseActor>();
        private int clickcount = 0;
        private bool p1v;
        private bool p2v;
        private bool p3v;
        public Form1()
        {
            InitializeComponent();
        }

        int tempclickX = 0;
        int tempclickY = 0;
        private void gfxPanel_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("sad");
            p1v = pictureBox1.Visible;
            p2v = pictureBox2.Visible;
            p3v = pictureBox3.Visible;

            if (ActorRadioButton.Checked)
            {
                LineRadioButton.Checked = false;
                UsecaseRadioButton.Checked = false;
                if (editRB.Checked)
                {
                    if (e.X < gfxPanel.Width - (gfxPanel.Width / 1.2))
                    {
                        if (!p1v)
                        {
                            pictureBox1.Visible = true;
                            Actor1text.Visible = true;
                        }
                        else if (!p2v)
                        {
                            pictureBox2.Visible = true;
                            Actor2text.Visible = true;
                        }
                        else if (!p3v)
                        {
                            pictureBox3.Visible = true;
                            Actor3text.Visible = true;
                        }
                    }
                }
                else if (selectRB.Checked)
                {

                }
            }
            if (LineRadioButton.Checked)
            {
                if (selectRB.Checked)
                {
                    clickcount += 1;
                    if (clickcount == 1)
                    {
                        tempclickX = e.X;
                        tempclickY = e.Y;
                    }
                    if (clickcount == 2)
                    {
                        UsecaseLine line = new UsecaseLine(e.X, e.Y, tempclickX, tempclickY);
                        ActorRadioButton.Checked = false;
                        UsecaseRadioButton.Checked = false;
                        Graphics GFX = gfxPanel.CreateGraphics();
                        Pen tempPen = new Pen(Color.Black);
                        GFX.DrawLine(tempPen, new Point(e.X, e.Y), new Point(tempclickX, tempclickY));
                        clickcount = 0;
                    }
                }
            }
            if (UsecaseRadioButton.Checked)
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (editRB.Checked)
            {
                changeVisibility(pictureBox1, Actor1text);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (editRB.Checked)
            {
                changeVisibility(pictureBox2, Actor2text);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (editRB.Checked)
            {
                changeVisibility(pictureBox3, Actor3text);
            }
        }

        private void changeVisibility(PictureBox pbtemp, TextBox txtboxtemp)
        {
            p1v = pictureBox1.Visible;
            p2v = pictureBox2.Visible;
            p3v = pictureBox3.Visible;

            if (ActorRadioButton.Checked)
            {
                LineRadioButton.Checked = false;
                UsecaseRadioButton.Checked = false;

                if (pbtemp.Visible)
                {
                    pbtemp.Visible = false;
                    txtboxtemp.Visible = false;
                }
            }
        }

        private void editRB_MouseClick(object sender, MouseEventArgs e)
        {
            selectRB.Checked = false;
        }

        private void selectRB_MouseClick(object sender, MouseEventArgs e)
        {
            editRB.Checked = false;
        }
    }
}
