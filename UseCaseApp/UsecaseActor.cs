using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace UseCaseApp
{
    class UsecaseActor
    {
        private PictureBox actor;
        List<UsecaseLine> lineList = new List<UsecaseLine>();

        public UsecaseActor(PictureBox actor)
        {
            this.Actor = actor;
        }

        public PictureBox Actor
        {
            get
            {
                return actor;
            }

            set
            {
                actor = value;
            }
        }

        public void createLine(Point lineStart, Point lineEnd, Panel gfxPanel)
        {
            lineList.Add(new UsecaseLine(lineStart, lineEnd, gfxPanel));
        }

        public void clearLines()
        {
            
            lineList = new List<UsecaseLine>();
        }
        
    }
}
