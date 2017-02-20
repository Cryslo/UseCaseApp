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
        private Point startLoc;
        private Point endLoc;
        Panel gfxPanel;
        public Rectangle targetRect;
        Pen tempPen = new Pen(Color.Black);

        public Point StartLoc
        {
            get
            {
                return startLoc;
            }
        }

        public Point EndLoc
        {
            get
            {
                return endLoc;
            }
        }

        public UsecaseLine(Point startLoc, Point endLoc, Panel gfxPanel)
        {
            this.startLoc = startLoc;
            this.endLoc = endLoc;
            this.gfxPanel = gfxPanel;

            Graphics GFX = gfxPanel.CreateGraphics();
            GFX.DrawLine(tempPen, startLoc, endLoc);
            PointF rectloc = Fraction(0.5f);
            targetRect = new Rectangle(Convert.ToInt32(rectloc.X), Convert.ToInt32(rectloc.Y), 10, 10);
            GFX.DrawRectangle(tempPen, targetRect);
        }

        public PointF Fraction(float frac)
        {
            return new PointF(StartLoc.X + frac * (EndLoc.X - StartLoc.X),
                               StartLoc.Y + frac * (EndLoc.Y - StartLoc.Y));
        }

        public void delete()
        {
            gfxPanel.Invalidate();
        }

        public void reDraw()
        {
            Graphics GFX = gfxPanel.CreateGraphics();
            GFX.DrawLine(tempPen, StartLoc, EndLoc);
            PointF rectloc = Fraction(0.5f);
            targetRect = new Rectangle(Convert.ToInt32(rectloc.X), Convert.ToInt32(rectloc.Y), 10, 10);
            GFX.DrawRectangle(tempPen, targetRect);
        }
    }
}
