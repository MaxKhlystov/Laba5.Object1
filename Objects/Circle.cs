using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace Laba5.Objeckt.Objects
{
    class Circle : BaseObject
    {
        private float size = 0;
        public Circle(float x, float y, float angle) : base(x, y, angle)
        {
            size = 80;
        }

        public bool RemoveCircle()
        {
            if (size <= 0)
            {
                return true;
            }
            else return false;
        }

        public override void Render(Graphics g)  
        {
            if (size > 0)
            {
                g.FillEllipse(
                    new SolidBrush(Color.LightGreen),
                    -size / 2, -size / 2, size, size
                );
                size -= 0.5f;
            }
        }

        public override GraphicsPath GetGraphicsPath()  
        {
            var path = base.GetGraphicsPath();
            path.AddEllipse(-size / 2, -size / 2, size, size);
            return path;
        }
    }
}
