using SFML.Graphics;
using SFML.Window;
using Snake.Scenes.Managment;
using Snake.Fundamentals;
using Snake.UI.Elements;
using Snake.UI;
using Snake.Scenes;

namespace Snake
{
    internal class Program
    {
        static ContextSettings settings = new ContextSettings(1, 1, 8);

        static RenderWindow window = new RenderWindow(new SFML.Window.VideoMode(700, 700), "Snake", SFML.Window.Styles.Titlebar, settings);

        static void Main(string[] args)
        {
            window.Closed += Close;
            window.SetKeyRepeatEnabled(false);

            while (window.IsOpen)
            {
                window.DispatchEvents();

                window.Clear(new Color(28, 18, 22, 255));

                Game.Run(window);

                window.Display();
            }
        }

        private static void Close(object? sender, EventArgs e)
        {
            window.Close();
        }
    }
}