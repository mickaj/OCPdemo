using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPdemo
{
    public class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Rectangle(int _width, int _height)
        {
            Height = _height;
            Width = _width;
        }
    }
}
