using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseApp
{
    class UsecaseLine
    {
        private int locX;
        private int locY;
        private int locX2;
        private int locY2;

        public UsecaseLine(int locX, int locY, int locX2, int locY2)
        {
            this.locX = locX;
            this.locY = locY;
            this.locX2 = locX2;
            this.locY2 = locY2;
        }
    }
}
