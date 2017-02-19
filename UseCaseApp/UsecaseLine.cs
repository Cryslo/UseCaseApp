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

        public UsecaseLine(Point startLoc, Point endLoc, Panel gfxPanel)
        {
            this.startLoc = startLoc;
            Console.WriteLine(startLoc);
            this.endLoc = endLoc;
            Console.WriteLine(endLoc);
            this.gfxPanel = gfxPanel;
            Graphics GFX = gfxPanel.CreateGraphics();
            Pen tempPen = new Pen(Color.Black);
            GFX.DrawLine(tempPen, startLoc, endLoc);
        }
    }
}
