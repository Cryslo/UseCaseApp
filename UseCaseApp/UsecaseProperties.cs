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
    }
}
