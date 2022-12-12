using SFML.Graphics;
using SFML.System;

namespace Snake.Fundamentals.GameObjects
{
    public class Field : GameObject
    {
        private Snake snake;
        private Apple apple;

        private List<RectangleShape> cells;

        public Field(int width, int height, RenderTarget target) 
        {
            snake = new Snake(target);

            cells = new List<RectangleShape>();

            for(int x = 0; x < width; x++)
            {
                for(int y = 0; y < height; y++)
                {
                    cells.Add(new RectangleShape(new Vector2f(16, 16) { X = x * width, Y = y * height }) { OutlineColor = Color.White, FillColor = Color.Black, OutlineThickness = 2}); 
                }
            }
        }
        public override void Update(RenderTarget target)
        {
            snake?.Update(target);
            apple?.Update(target);
        }

        public override void Draw(RenderTarget target, RenderStates states)
        {
            foreach(var cell in cells)
            {
                target.Draw(cell);
            }
        }
    }
}
