using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5.Objeckt.Objects
{
    class Circle : BaseObject
    {
        public Circle(float x, float y, float angle) : base(x, y, angle)
        {

        }
        public override void Render(Graphics g)
        {
            g.FillEllipse(
                new SolidBrush(Color.LightGreen),
                    -20, -20, 40, 40
            );
        }
    }
}
