using SFML.Graphics;

namespace Snake.UI
{
    public class ElementUIEventArgs : EventArgs
    {
        private string message { get; set; }
        public RenderTarget Target { get; set; }

        public ElementUIEventArgs(string message, RenderTarget target) 
        {
            this.message = message;
            Target = target;
        }
    }
}
