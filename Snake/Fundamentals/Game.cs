using SFML.Graphics;
using SFML.Window;
using Snake.Scenes;
using System.Runtime.CompilerServices;

namespace Snake.Fundamentals
{
    public static partial class Game
    {
        public static List<Scene>? Scenes { get; set; }
        public static Scene? CurrentScene { get; set; }

        private static Timer timer;
        private static ContextSettings contextSettings;
        private static RenderWindow window;

        static Game()
        {
            Initialize();
        }

        public static void Run()
        {
            while (window.IsOpen)
            {
                window.DispatchEvents();

                window.Clear(new Color(28, 18, 22, 255));

                if (timer.Tick())
                {
                    CurrentScene?.Update(window);
                }

                CurrentScene?.Draw(window);

                window.Display();
            }
        }
    }
}
