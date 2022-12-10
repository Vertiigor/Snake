using SFML.Graphics;
using Snake.Fundamentals;

namespace Snake.UI
{
   public delegate void ElementUIHandler(object sender, EventArgs e);

    public abstract class ElementUI : IUpdatable, Drawable
    {
        public Point? Origin { get; protected set; }

        public virtual void Draw(RenderTarget target, RenderStates states) { }

        public virtual void Update(RenderTarget target) { }
    }
}
