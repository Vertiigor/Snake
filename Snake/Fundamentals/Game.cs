using SFML.Graphics;
using Snake.Scenes;

namespace Snake.Fundamentals
{
    public static class Game
    {
        public static List<Scene> Scenes { get; set; }
        public static Scene? CurrentScene { get; set; }

        static Game()
        {
            Scenes = new List<Scene>();
        }

        public static void Run(RenderTarget target)
        {
            CurrentScene?.Update(target);
        }
    }
}
