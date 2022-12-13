namespace Snake.Fundamentals
{
    /// <summary>
    /// Interface defining an object that can move and have a direction of movement.
    /// </summary>
    public interface IMovable
    {
        public InputSystem.Direction direction { get; set; }
    }
}
