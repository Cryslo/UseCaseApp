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
    public partial class UsecaseProperties: Form
    {
        public Form1 parentForm { get; set; }

        public UsecaseProperties()
        {
            InitializeComponent();
        }
        public string getNaam()
        {
            return ucfNaamTxt.Text;
        }
        public string getSamenvatting()
        {
            return ucfSamenvTxt.Text;
        }
        public string getActoren()
        {
            return ucfActorTxt.Text;
        }
        public string getAannamen()
        {
            return ucfAannamenTxt.Text;
        }
        public string getBescrijving()
        {
            return ucfBescrijvingTxt.Text;
        }
        public string getUitzonderingen()
        {
            return ucfUitzonderingTxt.Text;
        }
        public string getResultaat()
        {
            return ucfResultaatTxt.Text;
        }

        public string getAllFields()
        {
            if (ucfNaamTxt.Text == "")
            {
                return "Empty";
            }
            else if (ucfAannamenTxt.Text == "")
            {
                return "Empty";
            }
            else if (ucfActorTxt.Text == "")
            {
                return "Empty";
            }
            else if (ucfBescrijvingTxt.Text == "")
            {
                return "Empty";
            }
            else if (ucfResultaatTxt.Text == "")
            {
                return "Empty";
            }
            else if (ucfSamenvTxt.Text == "")
            {
                return "Empty";
            }
            else if (ucfUitzonderingTxt.Text == "")
            {
                return "Empty";
            }
            else
            {
                return "NotEmpty";
            }
            
        }

        public void SetUsecaseData(string naam, string samenvatting, string resultaat, string uitzondering, string beschrijving, string actor, string aannamen)
        {
            ucfNaamTxt.Text = naam;
            ucfSamenvTxt.Text = samenvatting;
            ucfResultaatTxt.Text = resultaat;
            ucfUitzonderingTxt.Text = uitzondering;
            ucfBescrijvingTxt.Text = beschrijving;
            ucfActorTxt.Text = actor;
            ucfAannamenTxt.Text = aannamen;
        }

        private void updateUsecase_Click(object sender, EventArgs e)
        {
            parentForm.UpdateUsecase(ucfNaamTxt.Text, ucfSamenvTxt.Text, ucfResultaatTxt.Text, ucfUitzonderingTxt.Text, ucfBescrijvingTxt.Text, ucfActorTxt.Text, ucfAannamenTxt.Text);
        }
    }
}
