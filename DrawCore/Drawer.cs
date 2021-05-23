using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawCore
{
    abstract public class Drawer
    {
        public abstract void DrawLine(int x1, int y1, int x2, int y2);
        public abstract void DrawCircle(int x, int y, int r);
        public abstract void DrawTriangle(int x, int y, double z);
    }
}
