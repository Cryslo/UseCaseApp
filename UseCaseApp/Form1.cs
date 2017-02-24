using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*To-Do
 * Add a small square or elipse to a lines middle to make it targetable for deletion.
 * Prompt for user input with usecases before continuing
 * */





namespace UseCaseApp
{
    public partial class Form1 : Form
    {
        List<UsecaseActor> actorList = new List<UsecaseActor>();
        List<UsecaseOval> usecastList = new List<UsecaseOval>();
        private PictureBox selectedActor;
        private UsecaseOval selectedUsecase;
        UsecaseProperties usecasepropForm = new UsecaseProperties();

        int tempclickX = 0;
        int tempclickY = 0;
        public Form1()
        {
            InitializeComponent();
            usecasepropForm.parentForm = this;
            actorList.Add(new UsecaseActor(pictureBox1));
            actorList.Add(new UsecaseActor(pictureBox2));
            actorList.Add(new UsecaseActor(pictureBox3));
        }

        private bool p1v;
        private bool p2v;
        private bool p3v;
        private int clickcount = 0;
        private void gfxPanel_MouseClick(object sender, MouseEventArgs e)
        {
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
                if (editRB.Checked)
                {
                    if (clickcount == 0)
                    {
                        foreach (UsecaseOval item in usecastList)
                        {
                            if (item.Rect.Contains(e.Location))
                            {
                                tempclickX = item.Rect.Location.X + item.Rect.Width/2;
                                tempclickY = item.Rect.Location.Y + item.Rect.Height/2 + 10;
                            }
                        }
                        clickcount += 1;
                    }
                    else if (clickcount == 1)
                    {
                        ActorRadioButton.Checked = false;
                        UsecaseRadioButton.Checked = false;
                        foreach (UsecaseOval item in usecastList)
                        {
                            if (item.Rect.Contains(e.Location))
                            {
                                actorList[1].createLine(new Point(item.Rect.Location.X + item.Rect.Width / 2, item.Rect.Location.Y + item.Rect.Height / 2 + 10), new Point(tempclickX, tempclickY), gfxPanel);
                            }
                        }
                        clickcount = 0;
                    }
                }
                if (selectRB.Checked)
                {
                    foreach (UsecaseActor item in actorList)
                    {
                        foreach (UsecaseLine item2 in item.LineList)
                        {
                            if (item2.targetRect.Contains(new Point(e.X,e.Y)))
                            {

                                item.LineList.Remove(item2);
                                gfxPanel.Invalidate();
                                return;
                            }
                        }
                    }
                }
            }
            if (UsecaseRadioButton.Checked)
            {
                if (editRB.Checked)
                {
                    if (usecasepropForm.getAllFields() == "NotEmpty")
                    {
                        int sizex = 100;
                        int sizey = 50;
                        Rectangle rect = new Rectangle(e.X - (sizex / 2), e.Y - (sizey / 2), sizex, sizey);
                        usecastList.Add(new UsecaseOval(rect, gfxPanel,
                            usecasepropForm.getNaam(),
                            usecasepropForm.getSamenvatting(),
                            usecasepropForm.getActoren(),
                            usecasepropForm.getAannamen(),
                            usecasepropForm.getBescrijving(),
                            usecasepropForm.getUitzonderingen(),
                            usecasepropForm.getResultaat()
                            ));
                        selectedUsecase = usecastList.Last();
                    }
                    else
                    {
                        MessageBox.Show("Please fill in all fields.");
                    }
                }
                if (selectRB.Checked)
                {
                    foreach (UsecaseOval item in usecastList)
                    {
                        if (item.Rect.Contains(e.Location))
                        {
                            selectedUsecase = item;
                            usecasepropForm.SetUsecaseData(item.Naam, 
                                item.Samenvatting,
                                item.Resultaat,
                                item.Uitzonderingen,
                                item.Beschrijving,
                                item.Actoren,
                                item.Aannamen);
                        }
                    }

                }
            }
        }

        private void redrawCanvas()
        {
            foreach (UsecaseActor item in actorList)
            {
                foreach (UsecaseLine item2 in item.LineList)
                {
                    item2.reDraw();
                }
            }
            foreach (UsecaseOval item in usecastList)
            {
                item.reDraw();
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

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (editRB.Checked && ActorRadioButton.Checked)
            {
                changeVisibility(pictureBox1, Actor1text);
            }
            if (editRB.Checked && LineRadioButton.Checked)
            {
                if (clickcount == 0)
                {
                    selectedActor = pictureBox1;
                    tempclickX = selectedActor.Location.X + (selectedActor.Width/2);
                    tempclickY = selectedActor.Location.Y + (selectedActor.Height/2);
                    clickcount += 1;
                }
                else if (clickcount == 1)
                {
                    ActorRadioButton.Checked = false;
                    UsecaseRadioButton.Checked = false;
                    actorList[1].createLine(new Point(e.X, e.Y), new Point(e.X, e.Y), gfxPanel);
                    clickcount = 0;
                }
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (editRB.Checked && ActorRadioButton.Checked)
            {
                changeVisibility(pictureBox2, Actor2text);
            }
            if (editRB.Checked && LineRadioButton.Checked)
            {
                clickcount += 1;
                if (clickcount == 1)
                {
                    selectedActor = pictureBox2;
                    tempclickX = selectedActor.Location.X + (selectedActor.Width / 2);
                    tempclickY = selectedActor.Location.Y + (selectedActor.Height/2);
                }
                if (clickcount == 2)
                {
                    ActorRadioButton.Checked = false;
                    UsecaseRadioButton.Checked = false;
                    actorList[2].createLine(selectedActor.Location, new Point(e.X, e.Y), gfxPanel);
                    clickcount = 0;
                }
            }
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (editRB.Checked && ActorRadioButton.Checked)
            {
                changeVisibility(pictureBox3, Actor3text);
            }
            if (editRB.Checked && LineRadioButton.Checked)
            {
                clickcount += 1;
                if (clickcount == 1)
                {
                    selectedActor = pictureBox3;
                    tempclickX = selectedActor.Location.X + (selectedActor.Width / 2);
                    tempclickY = selectedActor.Location.Y + (selectedActor.Height/2);
                }
                if (clickcount == 2)
                {
                    ActorRadioButton.Checked = false;
                    UsecaseRadioButton.Checked = false;
                    actorList[3].createLine(selectedActor.Location, new Point(e.X, e.Y), gfxPanel);
                    clickcount = 0;
                }
            }
        }

        private void UsecaseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (UsecaseRadioButton.Checked)
            {
                usecasepropForm.Show();
            }
            else if (!UsecaseRadioButton.Checked)
            {
                usecasepropForm.Hide();
            }
        }

        private void clearCanvas_Click(object sender, EventArgs e)
        {
            foreach (UsecaseOval item in usecastList)
            {
                gfxPanel.Controls.Remove(item.Textlabel);
            }
            usecastList.Clear();
            foreach (UsecaseActor item in actorList)
            {
                item.clearLines();
                gfxPanel.Invalidate();
            }

            gfxPanel.Invalidate();
            changeVisibility(pictureBox1, Actor1text);
            changeVisibility(pictureBox2, Actor2text);
            changeVisibility(pictureBox3, Actor3text);
        }

        private void gfxPanel_Paint(object sender, PaintEventArgs e)
        {

            redrawCanvas();
        }

        public void UpdateUsecase(string naam, string samenvatting, string resultaat, string uitzondering, string beschrijving, string actor, string aannamen)
        {
            if (selectedUsecase != null)
            {
                gfxPanel.Invalidate();
                redrawCanvas();

                selectedUsecase.Textlabel.Text = naam;
                selectedUsecase.reDraw();
                selectedUsecase.Naam = naam;
                selectedUsecase.Samenvatting = samenvatting;
                selectedUsecase.Resultaat = resultaat;
                selectedUsecase.Uitzonderingen = uitzondering;
                selectedUsecase.Beschrijving = beschrijving;
                selectedUsecase.Actoren = actor;
                selectedUsecase.Aannamen = aannamen;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            gfxPanel.Controls.Remove(selectedUsecase.Textlabel);
            usecastList.Remove(selectedUsecase);
            gfxPanel.Invalidate();
            redrawCanvas();
        }
    }
}
