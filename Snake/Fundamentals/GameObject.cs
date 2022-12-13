using SFML.Graphics;

namespace Snake.Fundamentals
{
    public class GameObject : IUpdatable, Drawable
    {
        /// <summary>
        /// Object point on the coordinate plane.
        /// </summary>
        public Point Origin { get; set; }

        /// <summary>
        /// Draws an object.
        /// </summary>
        /// <param name="target">Object that will render the game object</param>
        /// <param name="states">Define the states used to draw</param>
        public virtual void Draw(RenderTarget target, RenderStates states) { }

        /// <summary>
        /// Updates the state of an object.
        /// </summary>
        /// <param name="target">>Object that will render the game objec</param>
        public virtual void Update(RenderTarget target) { }
    }
}
