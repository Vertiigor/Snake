using Snake.Fundamentals;
using SFML.System;
using SFML.Window;
using SFML.Graphics;

namespace Snake.UI.Elements
{
    public class Button : ElementUI, IClickable
    {
        public event ElementUIHandler? Click;
        public event ElementUIHandler? Aimed;

        public Text Text { get; private set; }
        public Color BackgroundColor { get => area.FillColor; 
            set 
            {
                area.FillColor = value;
            }}
        public Vector2f size { get; private set; }
        private RectangleShape area;
        private Color originalColor;

        public Button(float x, float y, string text, Font font, Color backgroundColor)
        {
            Origin = new Point(x, y);

            Text = new Text(text, font);
            Text.Position = new Vector2f(x + Text.CharacterSize, y + Text.CharacterSize / 4);

            this.size = new Vector2f(text.Length * Text.CharacterSize, Text.CharacterSize * 2);

            this.area = new RectangleShape(size);
            this.area.OutlineThickness = 2;
            this.area.OutlineColor = new Color(102, 102, 102, 255);
            this.area.Position = new Vector2f(x , y);

            originalColor = BackgroundColor = backgroundColor;
        }
        public override void Update(RenderTarget target)
        {
            if (Mouse.IsButtonPressed(Mouse.Button.Left) && area.GetGlobalBounds().Contains(Mouse.GetPosition((Window)target).X, Mouse.GetPosition((Window)target).Y))
            {
                Click?.Invoke(this, new ElementUIEventArgs("Clicked"));
            }
            if(area.GetGlobalBounds().Contains(Mouse.GetPosition((Window)target).X, Mouse.GetPosition((Window)target).Y))
            {
                Aimed?.Invoke(this, new ElementUIEventArgs("Button_Aimed"));
            }
            else
            {
                BackgroundColor = originalColor;
            }
        }

        public override void Draw(RenderTarget target, RenderStates states)
        {
            target.Draw(area);
            target.Draw(Text);
        }
    }
}
