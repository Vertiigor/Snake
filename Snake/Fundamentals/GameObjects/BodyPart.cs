using SFML.Graphics;

namespace Snake.Fundamentals.GameObjects
{
    public class BodyPart : GameObject
    {
        private RectangleShape rectangle;

        public BodyPart(float x, float y)
        {
            Origin = new Point(x, y);

            this.rectangle = new RectangleShape(new SFML.System.Vector2f(16, 16));
            this.rectangle.Position = new SFML.System.Vector2f(x * 16, y * 16);
            this.rectangle.FillColor= Color.White;
        }

        public override void Draw(RenderTarget target, RenderStates states)
        {
            target.Draw(this.rectangle);
        }
    }
}
