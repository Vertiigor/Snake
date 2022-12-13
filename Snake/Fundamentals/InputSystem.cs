using SFML.Graphics;
using SFML.Window;

namespace Snake.Fundamentals
{
    /// <summary>
    /// A class that receives information about input from the user.
    /// </summary>
    public class InputSystem
    {
        public enum Direction
        {
            Left,
            Right,
            Up,
            Down
        }

        private IMovable movable; // Movable object to which the input system will be attached.

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target">Object that will render the game object.</param>
        /// <param name="movable">Movable object to which the input system will be attached.</param>
        public InputSystem(RenderTarget target, IMovable movable)
        {
            (target as Window).KeyPressed += InputSystem_KeyPressed; // subscribe to data processing

            this.movable = movable;
        }

        private void InputSystem_KeyPressed(object? sender, KeyEventArgs e)
        {
            // set direction of movable object
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
