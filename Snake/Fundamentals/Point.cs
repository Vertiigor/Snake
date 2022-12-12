namespace Snake.Fundamentals
{
    public class Point
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            var other = obj as Point;

            return (int)this.X == (int)other?.X && (int)this.Y == (int)other?.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        public override string ToString()
        {
            return $"X: {X}\tY: {Y}\n";
        }
    }
}
