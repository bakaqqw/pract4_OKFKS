using pract4_OKFKS;
namespace pract4_OKFKS_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CreateRectangle()
        {
            pract4_OKFKS.Rectangle rec = new pract4_OKFKS.Rectangle();
            Assert.NotNull(rec);
        }

        [Fact]
        public void CreateTriangle()
        {
            pract4_OKFKS.Triangle tri = new pract4_OKFKS.Triangle();
            Assert.NotNull(tri);
        }

        [Fact]
        public void RectangleArea_check()
        {
            pract4_OKFKS.Rectangle rectangle = new pract4_OKFKS.Rectangle();

            rectangle.Width = 10;
            rectangle.Height = 2;

            double res = rectangle.Area();

            Assert.Equal(20, res);
        }

        [Fact]
        public void RectangleArea_checkException()
        {
            pract4_OKFKS.Rectangle rectangle = new pract4_OKFKS.Rectangle();

            rectangle.Width = 0;
            rectangle.Height = -2;

            var ex = Assert.Throws<ArgumentException>(() => rectangle.Area());

            Assert.Contains("error!", ex.Message.ToString());
        }

        [Fact]
        public void RectanglePerimetre_check()
        {
            pract4_OKFKS.Rectangle rectangle = new pract4_OKFKS.Rectangle();

            rectangle.Width = 10;
            rectangle.Height = 2;

            double res = rectangle.Perimeter();

            Assert.Equal(24, res);
        }

        [Fact]
        public void RectanglePerimetre_checkException()
        {
            pract4_OKFKS.Rectangle rectangle = new pract4_OKFKS.Rectangle();

            rectangle.Width = 0;
            rectangle.Height = -2;

            var ex = Assert.Throws<ArgumentException>(() => rectangle.Perimeter());

            Assert.Contains("error!", ex.Message.ToString());
        }

    }
}