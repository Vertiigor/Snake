using SFML.Graphics;
using SFML.Window;

namespace Snake.Fundamentals.GameObjects
{
    public class Snake : GameObject, IMovable
    {
        private InputSystem inputSystem;

        public InputSystem.Direction direction { get; set; }

        public Snake(RenderTarget target)
        {
            this.inputSystem = new InputSystem(target, this);

            this.direction = InputSystem.Direction.Up;
        }
        public override void Update(RenderTarget target)
        {
            
        }

        public override void Draw(RenderTarget target, RenderStates states)
        {
            
        }
    }
}
