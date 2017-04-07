using OCPdemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Transformations.Tests
{
    public class GoodTests
    {
        private Rectangle rectangle;
        private ITransform transformation;
        private Rectangle result;
        private void execute(ITransform _transformation)
        {
            transformation = _transformation;
            rectangle = new Rectangle(10, 20);
        }

        [Fact]
        public void testRotation90()
        {
            execute(new Rotate90());
            Rectangle expected = new Rectangle(20, 10);
            Compare(expected);
        }

        [Fact]
        public void testScale2x()
        {
            execute(new Scale(2));
            Rectangle expected = new Rectangle(rectangle.Width * 2, rectangle.Height * 2);
            Compare(expected);
        }

        [Fact]
        public void testVerticalCut()
        {
            execute(new VerticalHalf());
            Rectangle expected = new Rectangle(rectangle.Width / 2, rectangle.Height);
            Compare(expected);
        }

        private void Compare(Rectangle expected)
        {
            result = transformation.Transform(rectangle);
            Assert.Equal(expected.Height, result.Height);
            Assert.Equal(expected.Width, result.Width);
        }
    }
}
