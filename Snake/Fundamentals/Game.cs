using SFML.Graphics;
using Snake.Scenes;

namespace Snake.Fundamentals
{
    public static partial class Game
    {
        public static List<Scene>? Scenes { get; set; }
        public static Scene? CurrentScene { get; set; }

        static Game()
        {
            Initialize();
        }

        public static void Run(RenderTarget target)
        {
            CurrentScene?.Update(target);
        }
    }
}
