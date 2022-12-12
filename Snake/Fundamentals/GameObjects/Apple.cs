using SFML.Graphics;

namespace Snake.Fundamentals.GameObjects
{
    public class Apple : GameObject
    {
        private RectangleShape rect;

        public Apple(float x, float y)
        {
            Origin = new Point(x, y);

            this.rect = new RectangleShape(new SFML.System.Vector2f(16, 16));
            this.rect.Position = new SFML.System.Vector2f(x * 16, y * 16);
            this.rect.FillColor = Color.Red;
        }

        public override void Draw(RenderTarget target, RenderStates states)
        {
            target.Draw(rect);
        }
    }
}
