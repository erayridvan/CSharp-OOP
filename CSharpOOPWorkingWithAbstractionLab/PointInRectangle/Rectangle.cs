namespace PointInRectangle
{
    public class Rectangle
    {
        public Rectangle(int top, int left, int bottom, int right)
        {
            this.TopLeft = new Point(left, top);
            this.BottomRight = new Point(right, bottom); 
        }

        public Point TopLeft { get; set; }

        public Point BottomRight { get; set; }

        public bool Contains(Point point)
        {
            if (point.X>=TopLeft.X && point.X<=BottomRight.X &&
                point.Y<=TopLeft.Y && point.Y>=BottomRight.Y)
            {
                return true;
            }

            return false;
        }
    }
}
