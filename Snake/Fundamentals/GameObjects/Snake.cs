using SFML.Graphics;
using Snake.Scenes.Managment;

namespace Snake.Fundamentals.GameObjects
{
    public class Snake : GameObject, IMovable
    {
        private InputSystem inputSystem;
        private List<BodyPart> bodyParts;

        public InputSystem.Direction direction { get; set; }
        public int Length { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target">Object that will render the game object.</param>
        public Snake(RenderTarget target)
        {
            this.inputSystem = new InputSystem(target, this);

            this.direction = InputSystem.Direction.Right;

            this.Origin = new Point(1, 1);

            this.bodyParts = new List<BodyPart>();

            bodyParts.Add(new BodyPart(1, 1));

            this.Length = 1;
        }
        public override void Update(RenderTarget target)
        {
            // determining the player's movement vector, changes coordinates and adding new body parts
            switch (direction)
            {
                case InputSystem.Direction.Left:
                    if ((int)(Origin.X - 0.2f) < (int)Origin.X)
                        bodyParts.Add(new BodyPart((int)Origin.X, (int)Origin.Y));
                    Origin.X -= 0.2f;
                    break;
                case InputSystem.Direction.Right:
                    if ((int)(Origin.X + 0.2f) > (int)Origin.X)
                        bodyParts.Add(new BodyPart((int)Origin.X, (int)Origin.Y));
                    Origin.X += 0.2f;
                    break;
                case InputSystem.Direction.Up:
                    if ((int)(Origin.Y - 0.2f) < (int)Origin.Y)
                        bodyParts.Add(new BodyPart((int)Origin.X, (int)Origin.Y));
                    Origin.Y -= 0.2f;
                    break;
                case InputSystem.Direction.Down:
                    if ((int)(Origin.Y + 0.2f) > (int)Origin.Y)
                        bodyParts.Add(new BodyPart((int)Origin.X, (int)Origin.Y));
                    Origin.Y += 0.2f;
                    break;
            }
            if (bodyParts.Count > Length)
            {
                bodyParts.RemoveAt(0); // cut off excess body parts
            }

            if (bodyParts.Find(b => b.Origin.Equals(this.Origin)) != null && Length > 1) // collision with one's own body part
            {
                Console.WriteLine("Collision");
                SceneManager.LoadScene("Menu");
            }
        }

        public override void Draw(RenderTarget target, RenderStates states)
        {
            foreach(var part in bodyParts)
            {
                target.Draw(part);
            }
        }
    }
}
