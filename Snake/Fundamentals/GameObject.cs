using SFML.Graphics;

namespace Snake.Fundamentals
{
    public class GameObject : IUpdatable, Drawable
    {
        public Point Origin { get; set; }
        public virtual void Draw(RenderTarget target, RenderStates states) { }

        public virtual void Update(RenderTarget target) { }
    }
}
