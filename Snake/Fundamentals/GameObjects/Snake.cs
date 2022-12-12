using SFML.Graphics;
using SFML.Window;

namespace Snake.Fundamentals.GameObjects
{
    public class Snake : GameObject, IMovable
    {
        private InputSystem inputSystem;

        public InputSystem.Direction direction { get; set; }

        private RectangleShape rect;

        public Snake(RenderTarget target)
        {
            this.inputSystem = new InputSystem(target, this);

            this.direction = InputSystem.Direction.Right;

            Origin = new Point(1, 1);

            rect = new RectangleShape(new SFML.System.Vector2f(16, 16));
        }
        public override void Update(RenderTarget target)
        {
            switch (direction)
            {
                case InputSystem.Direction.Left:
                    Origin.X -= 0.2f;
                    rect.Position = new SFML.System.Vector2f((int)Origin.X * 16, (int)Origin.Y * 16);
                    break;
                case InputSystem.Direction.Right:
                    Origin.X += 0.2f;
                    rect.Position = new SFML.System.Vector2f((int)Origin.X * 16, (int)Origin.Y * 16);
                    break;
                case InputSystem.Direction.Up:
                    Origin.Y -= 0.2f;
                    rect.Position = new SFML.System.Vector2f((int)Origin.X * 16, (int)Origin.Y * 16);
                    break;
                case InputSystem.Direction.Down:
                    Origin.Y += 0.2f;
                    rect.Position = new SFML.System.Vector2f((int)Origin.X * 16, (int)Origin.Y * 16);
                    break;
            }
        }

        public override void Draw(RenderTarget target, RenderStates states)
        {
            target.Draw(rect);
        }
    }
}
