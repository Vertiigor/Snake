using SFML.Graphics;
using Snake.Scenes;
using System.Runtime.CompilerServices;

namespace Snake.Fundamentals
{
    public static partial class Game
    {
        public static List<Scene>? Scenes { get; set; }
        public static Scene? CurrentScene { get; set; }
        private static Timer timer;

        static Game()
        {
            Initialize();

            timer = new Timer(16.6f);
        }

        public static void Run(RenderTarget target)
        {
            if (timer.Tick())
            {
                CurrentScene?.Update(target);
            }

            CurrentScene?.Draw(target);
        }
    }
}
