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

        public UsecaseOval(Rectangle rect, Panel gfxPanel)
        {
            this.rect = rect;
            this.gfxPanel = gfxPanel;

            Graphics GFX = gfxPanel.CreateGraphics();
            Pen tempPen = new Pen(Color.Black);
            GFX.DrawEllipse(tempPen, rect);
        }
    }
}
