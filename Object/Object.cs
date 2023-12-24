using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Object
{
    public class Object
    {
        public Point[] Point_Pos = new Point[2];
        public Object() 
        {
            Point_Pos[0] = new Point(0, 0);
            Point_Pos[1] = new Point(0, 0);
        }
    }

    public class Draw_Rect : Object
    {
        public Draw_Rect()
        {

        }
    }

    public class Draw_Elipse : Object
    {

    }

    public class Draw_CrossLine : Object
    {

    }
}
