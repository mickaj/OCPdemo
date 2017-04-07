using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPdemo
{
    public interface ITransform
    {
        Rectangle Transform(Rectangle _rect);
    }

    public class Rotate90 : ITransform
    {
        public Rectangle Transform(Rectangle _rect)
        {
            return new Rectangle(_rect.Height, _rect.Width);
        }
    }

    public class Scale : ITransform
    {
        private double scale;
        public Scale(double _scale)
        {
            scale = _scale;
        }

        public Rectangle Transform(Rectangle _rect)
        {
            return new Rectangle(Convert.ToInt32(_rect.Width* scale), Convert.ToInt32(_rect.Height* scale));
        }
    }

    public class VerticalHalf : ITransform
    {
        public Rectangle Transform(Rectangle _rect)
        {
            return new Rectangle(_rect.Width / 2, _rect.Height);
        }
    }
}
