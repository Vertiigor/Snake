using SFML.Graphics;

namespace Snake.Fundamentals
{
    /// <summary>
    /// Interface defining an object that can be updated.
    /// </summary>
    public interface IUpdatable
    {
        public void Update(RenderTarget target);
    }
}
