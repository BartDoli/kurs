namespace course_alx.Lessons.Classes
{
    internal class L1Constructors
    {
        public static void Test()
        {
            var spider = new Spider();
            spider.Color = "black";
            spider.Species = "Black Widow";
            spider.IsVenomous = true;
            spider.Sex = "female";

            var redSpider = new Spider("red", "tarantula", false, "male");

            var blueSpider = new Spider("blue", "Goliath");
        }
    }
}
