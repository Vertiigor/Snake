using SFML.Graphics;
using SFML.System;
using Snake.Fundamentals;

namespace Snake.UI.Elements
{
    public class Label : ElementUI
    {
        private Text? text;
        private string? value;

        public Font? Font { get; set; }
        public string Text
        {
            get => this.value; 
            set
            {
                this.value = value;
                this.text = new Text(value, Font);
                this.text.Position = new Vector2f(Origin.X, Origin.Y);
            }
        }

        public Label(float x, float y, string text, Font font)
        {
            Origin = new Point(x, y);

            this.Font = font;
            Text = text;

            this.text.Position = new Vector2f(x, y);
        }

        public override void Draw(RenderTarget target, RenderStates states)
        {
            target.Draw(text);
        }
    }
}
