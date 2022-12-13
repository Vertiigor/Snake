using SFML.Graphics;
using Snake.Fundamentals;

namespace Snake.UI
{
   public delegate void ElementUIHandler(object sender, EventArgs e);

    public abstract class ElementUI : IUpdatable, Drawable
    {
        public Point? Origin { get; protected set; }

        /// <summary>
        /// Draws an object.
        /// </summary>
        /// <param name="target">Object that will render the UI object</param>
        /// <param name="states">Define the states used to draw</param>
        public virtual void Draw(RenderTarget target, RenderStates states) { }

        /// <summary>
        /// Updates the state of an object.
        /// </summary>
        /// <param name="target">>Object that will render the UI objec</param>
        public virtual void Update(RenderTarget target) { }
    }
}
