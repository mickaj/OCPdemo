using OCPdemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Transformations.Tests
{
    public class BadTransformationsTest
    {
        private Rectangle _rectangle;
        private void execute()
        {
            _rectangle = new Rectangle(10, 20);
        }

        [Fact]
        public void testRotation90()
        {
            execute();
            Rectangle expected = new Rectangle(20, 10);
            Rectangle result = TransformationsBad.Rotate90(_rectangle);
            Compare(expected, result);
        }

        [Fact]
        public void testScale2x()
        {
            execute();
            Rectangle expected = new Rectangle(_rectangle.Width * 2, _rectangle.Height * 2);
            Rectangle result = TransformationsBad.Scale(_rectangle, 2);
            Compare(expected, result);
        }

        private void Compare(Rectangle expected, Rectangle result)
        {
            Assert.Equal(expected.Height, result.Height);
            Assert.Equal(expected.Width, result.Width);
        }
    }
}
