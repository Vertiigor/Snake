using SFML.Graphics;

namespace Snake.UI
{
    public class ElementUIEventArgs : EventArgs
    {
        private string message { get; set; }

        public ElementUIEventArgs(string message) 
        {
            this.message = message;
        }
    }
}
