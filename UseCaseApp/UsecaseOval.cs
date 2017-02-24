using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCaseApp
{
    class UsecaseOval
    {
        Rectangle rect;
        Panel gfxPanel;
        private string naam;
        private string samenvatting;
        private string actoren;
        private string aannamen;
        private string beschrijving;
        private string uitzonderingen;
        private string resultaat;

        Pen tempPen = new Pen(Color.Black);
        Label textlabel;

        public Rectangle Rect
        {
            get
            {
                return rect;
            }
        }

        public string Naam
        {
            get
            {
                return naam;
            }
            set
            {
                naam = value;
            }
        }

        public string Samenvatting
        {
            get
            {
                return samenvatting;
            }
            set
            {
                samenvatting = value;
            }
        }

        public string Actoren
        {
            get
            {
                return actoren;
            }

            set
            {
                actoren = value;
            }
        }

        public string Aannamen
        {
            get
            {
                return aannamen;
            }

            set
            {
                aannamen = value;
            }
        }

        public string Beschrijving
        {
            get
            {
                return beschrijving;
            }

            set
            {
                beschrijving = value;
            }
        }

        public string Uitzonderingen
        {
            get
            {
                return uitzonderingen;
            }

            set
            {
                uitzonderingen = value;
            }
        }

        public string Resultaat
        {
            get
            {
                return resultaat;
            }

            set
            {
                resultaat = value;
            }
        }

        public Label Textlabel
        {
            get
            {
                return textlabel;
            }

            set
            {
                textlabel = value;
            }
        }

        public UsecaseOval(Rectangle rect, Panel gfxPanel, string naam, string samenvatting, string actoren, string aannamen, string beschrijving, string uitzonderingen, string resultaat)
        {
            this.rect = rect;
            this.gfxPanel = gfxPanel;
            this.naam = naam;
            this.samenvatting = samenvatting;
            this.actoren = actoren;
            this.aannamen = aannamen;
            this.beschrijving = beschrijving;
            this.uitzonderingen = uitzonderingen;
            this.resultaat = resultaat;


            Graphics GFX = this.gfxPanel.CreateGraphics();
            textlabel = new Label();
            this.gfxPanel.Controls.Add(textlabel);
            this.textlabel.AutoSize = true;
            this.textlabel.Text = this.naam;
            this.rect.Width = this.textlabel.Width + 10;
            this.textlabel.Location = new Point(this.rect.Location.X + 5, this.rect.Location.Y + this.textlabel.Height);
            GFX.DrawEllipse(this.tempPen, this.rect);
            GFX.Dispose();
        }
        
        public void reDraw()
        {
            rect.Width = textlabel.Width + 10;
            textlabel.Location = new Point(rect.Location.X + 5, rect.Location.Y + textlabel.Height);
            Graphics GFX = gfxPanel.CreateGraphics();
            GFX.DrawEllipse(tempPen, rect);
            GFX.Dispose();
        }
    }
}
