using SFML.Graphics;

namespace Snake.Fundamentals
{
    public class GameObject : IUpdatable, Drawable
    {
        public virtual void Draw(RenderTarget target, RenderStates states) { }

        public virtual void Update(RenderTarget target) { }
    }
}
