using pract4_OKFKS;
namespace pract4_OKFKS_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void RectangleCheckArea()
        {
            Rectangle rec = new Rectangle();
            rec.Width = 5;
            rec.Height = 8;

            double res = rec.Area();
            Assert.Equal(res,40);

        }

        [Fact]
        public void RectangleCheckPerimeter()
        {
            Rectangle rec = new Rectangle();
            rec.Width = 5;
            rec.Height = 8;

            double res = rec.Perimeter();
            Assert.Equal(res, 80);
        }

        [Fact]
        public void RectangleAreaCheckExceptions()
        {
            Rectangle rec = new Rectangle();
            rec.Width = -9;
            rec.Height = 0;

            var ex = Assert.Throws<ArgumentException>(() => rec.Area());
            Assert.Contains("Недопустимые числа, попробуй другие!", ex.Message.ToString());
        }

        [Fact]
        public void RectanglePerimeterCheckExceptions()
        {
            Rectangle rec = new Rectangle();
            rec.Width = 0;
            rec.Height = -1;
            
            var ex = Assert.Throws<ArgumentException>(() => rec.Perimeter());
            Assert.Contains("Недопустимые числа, попробуй другие!", ex.Message.ToString());
        }

        [Fact]
        public void CreateRectangle()
        {
            Rectangle rec = new Rectangle();
            Assert.NotNull(rec);
        }

        [Fact]
        public void CreateTriangle()
        {
            Triangle rec = new Triangle();
            Assert.NotNull(rec);
        }

    }
}