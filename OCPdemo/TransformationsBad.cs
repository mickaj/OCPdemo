using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPdemo
{
    public static class TransformationsBad
    {
        public static Rectangle Rotate90(Rectangle _rect)
        {
            return new Rectangle(_rect.Height, _rect.Width);
        }

        public static Rectangle Scale(Rectangle _rect, double _scale)
        {
            return new Rectangle(Convert.ToInt32(_rect.Width * _scale), Convert.ToInt32(_rect.Height * _scale));
        }
    }
}
