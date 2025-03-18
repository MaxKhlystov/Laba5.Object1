using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5.Objeckt.Objects
{
    class MyRectangle : BaseObject
    {
        public MyRectangle(float x, float y, float angle) : base(x, y, angle)
        {
        }

        public override void Render(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Yellow), -25, -25, 50, 50);
            g.DrawRectangle(new Pen(Color.Red, 2), -25, -25, 50, 50);
        }
    }
}
