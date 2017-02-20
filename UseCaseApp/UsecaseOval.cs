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

        public Rectangle Rect
        {
            get
            {
                return rect;
            }

            set
            {
                rect = value;
            }
        }

        public UsecaseOval(Rectangle rect, Panel gfxPanel, string naam, string samenvatting, string actoren, string aannamen, string beschrijving, string uitzonderingen, string resultaat)
        {
            this.Rect = rect;
            this.gfxPanel = gfxPanel;
            this.naam = naam;
            this.samenvatting = samenvatting;
            this.actoren = actoren;
            this.aannamen = aannamen;
            this.beschrijving = beschrijving;
            this.uitzonderingen = uitzonderingen;
            this.resultaat = resultaat;

            Graphics GFX = gfxPanel.CreateGraphics();
            GFX.DrawEllipse(tempPen, rect);
            GFX.Dispose();
        }
        
        public void reDraw()
        {
            Graphics GFX = gfxPanel.CreateGraphics();
            GFX.DrawEllipse(tempPen, rect);
            GFX.Dispose();
        }
    }
}
