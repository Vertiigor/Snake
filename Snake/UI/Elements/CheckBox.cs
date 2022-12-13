using SFML.Graphics;
using SFML.System;
using SFML.Window;
using Snake.Fundamentals;

namespace Snake.UI.Elements
{
    public class CheckBox : ElementUI, IClickable
    {
        private RectangleShape border, isChecked;
        private bool value, selected;
        private string text;

        public event ElementUIHandler? Click;
        public event ElementUIHandler? Aimed;
        public Text Text { get; set; }


        public bool Value 
        {
            get => this.value; 
            set
            {
                this.value = value;

                isChecked.FillColor = Value == true ? Color.White : new Color(0, 0, 0, 0);
            }
        }
        public CheckBox(float x, float y, string text, Font font, bool value = false) 
        {
            Origin = new Point(x, y);

            this.border = new RectangleShape(new Vector2f(50, 50));
            this.border.FillColor = new Color(0, 0, 0, 0);
            this.border.OutlineThickness = 2;
            this.border.OutlineColor = new Color(102, 102, 102, 255);
            this.border.Position = new Vector2f(x, y);

            this.isChecked = new RectangleShape(new Vector2f(50, 50));
            this.isChecked.FillColor = new Color(0, 0, 0, 0);
            this.isChecked.Position = new Vector2f(x, y);

            this.text = text;

            Value = value;

            Text = new Text(text, font);
            Text.Position = new Vector2f(Origin.X + 60, Origin.Y);


        }
        public override void Update(RenderTarget target)
        {
            FloatRect area = new FloatRect(new Vector2f(Origin.X, Origin.Y), new Vector2f(text.Length * Text.CharacterSize + 60, 60));

            if (Mouse.IsButtonPressed(Mouse.Button.Left) && area.Contains(Mouse.GetPosition((Window)target).X, Mouse.GetPosition((Window)target).Y) && selected == false)
            {
                Value = !Value;
                Click?.Invoke(this, new ElementUIEventArgs("Clicked"));
                selected = true;
            }
            if (area.Contains(Mouse.GetPosition((Window)target).X, Mouse.GetPosition((Window)target).Y))
            {
                border.OutlineColor = Color.Cyan;
                Aimed?.Invoke(this, new ElementUIEventArgs("CheckBox_Aimed"));
            }
            else
            {
                border.OutlineColor = new Color(102, 102, 102, 255);
                selected = false;
            }
        }

        public override void Draw(RenderTarget target, RenderStates states)
        {
            target.Draw(isChecked);
            target.Draw(border);
            target.Draw(Text);
        }

    }
}
