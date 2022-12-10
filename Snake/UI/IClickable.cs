namespace Snake.UI
{
    public interface IClickable
    {
        public event ElementUIHandler? Click;
        public event ElementUIHandler? Aimed;
    }
}
