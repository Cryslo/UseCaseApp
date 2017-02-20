using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCaseApp
{
    class UsecaseLine
    {
        Point startLoc;
        Point endLoc;
        Panel gfxPanel;
        Rectangle targetRect;


        public UsecaseLine(Point startLoc, Point endLoc, Panel gfxPanel)
        {
            this.startLoc = startLoc;
            this.endLoc = endLoc;
            this.gfxPanel = gfxPanel;

            Graphics GFX = gfxPanel.CreateGraphics();
            Pen tempPen = new Pen(Color.Black);
            GFX.DrawLine(tempPen, startLoc, endLoc);
            PointF rectloc = Fraction(0.5f);
            targetRect = new Rectangle(Convert.ToInt32(rectloc.X), Convert.ToInt32(rectloc.Y), 10, 10);
            GFX.DrawRectangle(tempPen, targetRect);
        }

        public PointF Fraction(float frac)
        {
            return new PointF(startLoc.X + frac * (endLoc.X - startLoc.X),
                               startLoc.Y + frac * (endLoc.Y - startLoc.Y));
        }
    }
}
