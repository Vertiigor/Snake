using SFML.Graphics;
using SFML.Window;
using Snake.Scenes;

namespace Snake.Fundamentals
{
    public static partial class Game
    {
        private static Timer timer;
        private static ContextSettings contextSettings;
        private static RenderWindow window;

        public static List<Scene>? Scenes { get; set; } // all registered game scenes
        public static Scene? CurrentScene { get; set; } // current game scene


        static Game()
        {
            Initialize();
        }

        /// <summary>
        /// Starts game session.
        /// </summary>
        public static void Run()
        {
            while (window.IsOpen)
            {
                window.DispatchEvents();

                window.Clear(new Color(28, 18, 22, 255));

                if (timer.Tick())
                {
                    CurrentScene?.Update(window); // updating the current scene every certain period of time
                }

                CurrentScene?.Draw(window);

                window.Display();
            }
        }
    }
}
