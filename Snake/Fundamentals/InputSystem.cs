using SFML.Graphics;
using SFML.Window;

namespace Snake.Fundamentals
{
    public class InputSystem
    {
        public enum Direction
        {
            Left,
            Right,
            Up,
            Down
        }

        private IMovable movable;

        public InputSystem(RenderTarget target, IMovable movable)
        {
            (target as Window).KeyPressed += InputSystem_KeyPressed;

            this.movable = movable;
        }

        private void InputSystem_KeyPressed(object? sender, KeyEventArgs e)
        {
            switch (e.Code)
            {
                case Keyboard.Key.W:
                    Console.WriteLine("Up");
                    movable.direction = Direction.Up;
                    break;
                case Keyboard.Key.A:
                    Console.WriteLine("Left");
                    movable.direction = Direction.Left;
                    break;
                case Keyboard.Key.S:
                    Console.WriteLine("Down");
                    movable.direction = Direction.Down;
                    break;
                case Keyboard.Key.D:
                    Console.WriteLine("Right");
                    movable.direction = Direction.Right;
                    break;
            }
        }
    }
}
