namespace WordFiller.Kinect
{
    public class Movement
    {
        public int HandX { get; set; }
        public int HandY { get; set; }
        public static bool Dragging { get; set; }

        public int ViewHeight { get; set; }
        public int ViewWidth { get; set; }
    }
}
