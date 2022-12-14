using SFML.Graphics;
using SFML.System;

namespace Snake.Fundamentals.GameObjects
{
    public class Field : GameObject
    {
        private Snake snake;
        private Apple apple;
        private List<RectangleShape> cells;
        private Random rnd;
        private int width, height;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="width">Field's width.</param>
        /// <param name="height">Field's height.</param>
        /// <param name="target">Object that will render the game object.</param>
        public Field(int width, int height, RenderTarget target) 
        {
            this.width = width;
            this.height = height;

            this.rnd = new Random();

            this.snake = new Snake(target);
            this.apple = new Apple(rnd.Next(0, width), rnd.Next(0, height));

            this.cells = new List<RectangleShape>();

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

            // if the player collided with an apple
            if (apple.Origin.Equals(snake.Origin))
            {
                apple = new Apple(rnd.Next(0, width), rnd.Next(0, height)); // relocate apple
                snake.Length++;
                Game.ScoreRised();
            }
        }

        public override void Draw(RenderTarget target, RenderStates states)
        {
            foreach(var cell in cells)
            {
                target.Draw(cell);
            }
            target.Draw(apple);
            target.Draw(snake);
        }
    }
}
