using SFML.Graphics;
using SFML.Window;
using Snake.Scenes.SceneManager;
using Snake.Fundamentals;
using Snake.UI.Elements;
using Snake.UI;
using Snake.Scenes;

namespace Snake
{
    internal class Program
    {
        static ContextSettings settings = new ContextSettings(1, 1, 8);

        static RenderWindow window = new RenderWindow(new SFML.Window.VideoMode(700, 700), "Snake", SFML.Window.Styles.Close, settings);

        static void Main(string[] args)
        {
            string ASSETS_PATH = Path.Combine(Directory.GetCurrentDirectory(), "Assets");

            window.Closed += Close;
            window.SetKeyRepeatEnabled(false);

            Font font = new Font(ASSETS_PATH + "\\Fonts\\PF.ttf");

            //Menu
            #region

            Button buttonStart = new Button(300, 100, "Start", font, new Color(76, 0, 32, 255));
            buttonStart.Click += Start;
            buttonStart.Aimed += Button_Aimed;

            Button buttonSettings = new Button(300, 200, "Settings", font, new Color(76, 0, 32, 255));
            buttonSettings.Click += ButtonSettings_Click;
            buttonSettings.Aimed += Button_Aimed;

            Button buttonQuit = new Button(300, 300, "Quit", font, new Color(76, 0, 32, 255));
            buttonQuit.Click += Close;
            buttonQuit.Aimed += Button_Aimed;

            Scene menu = new Scene("Menu", new ElementUI[] { buttonQuit, buttonSettings, buttonStart },
                                   new GameObject[] {});

            #endregion

            //Settings
            #region
            Button buttonBack = new Button(10, 10, "Back", font, new Color(100, 31, 21, 255));
            buttonBack.Click += ButtonBack_Click;
            buttonBack.Aimed += Button_Aimed;

            CheckBox checkBox = new CheckBox(10, 100, "Vertical Sync", font);
            checkBox.Click += CheckBox_Click;

            Scene settings = new Scene("Settings", new ElementUI[] { buttonBack, checkBox },
                                   new GameObject[] { });
            #endregion

            Game.CurrentScene = menu;

            while (window.IsOpen)
            {
                window.DispatchEvents();

                window.Clear(new Color(28, 18, 22, 255));

                Game.Run(window);

                window.Display();
            }
        }

        private static void CheckBox_Click(object sender, EventArgs e)
        {
            window.SetVerticalSyncEnabled((sender as CheckBox).Value);
        }

        private static void ButtonBack_Click(object sender, EventArgs e)
        {
            SceneManager.LoadScene("Menu");
        }

        private static void Close(object? sender, EventArgs e)
        {
            window.Close();
        }

        private static void Start(object? sender, EventArgs e)
        {
            Console.WriteLine("Started");
        }

        private static void Button_Aimed(object? sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.BackgroundColor = new Color(102, 102, 102, 255);
        }

        private static void ButtonSettings_Click(object? sender, EventArgs e)
        {
            SceneManager.LoadScene("Settings");
        }
    }
}