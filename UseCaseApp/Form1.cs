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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void gfxPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (ActorRadioButton.Checked)
            {
                LineRadioButton.Checked = false;
                UsecaseRadioButton.Checked = false;
                if (e.X < gfxPanel.Width - (gfxPanel.Width / 1.2))
                {
                    Image img = Properties.Resources.Actor;
                    PictureBox pb1 = new PictureBox();
                    pb1.Image = img;
                    pb1.Size = new Size(50, 100);
                    pb1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb1.Location = new Point(e.X - 5, e.Y + pb1.Height);
                    this.Controls.Add(pb1);
                    pb1.BringToFront();
                }
            }
            if (LineRadioButton.Checked)
            {
                ActorRadioButton.Checked = false;
                UsecaseRadioButton.Checked = false;
                Graphics GFX = gfxPanel.CreateGraphics();
                Pen tempPen = new Pen(Color.Black);
                GFX.DrawLine(tempPen, new Point(e.X, e.Y), new Point(50, 50));
            }
            if (UsecaseRadioButton.Checked)
            {

            }
        }
    }
}
