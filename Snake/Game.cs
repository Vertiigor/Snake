using SFML.Graphics;
using SFML.Window;
using Snake.Fundamentals.GameObjects;
using Snake.Scenes;
using Snake.Scenes.Managment;
using Snake.UI;
using Snake.UI.Elements;

namespace Snake.Fundamentals
{
    public static partial class Game
    {
        //Other
        private static Font? font;
        private static int clickCount = 0;

        //Menu
        private static Button? buttonStart;
        private static Button? buttonSettings;
        private static Button? buttonQuit;
        private static Label? labelMenu;
        private static Scene? menu;

        //Settings
        private static Button? buttonMenuBack;
        private static Button? buttonCounter;
        private static Label? labelExample;
        private static CheckBox? checkBox;
        private static Scene? settings;

        //Game
        private static Button? buttonGameBack;
        private static Scene? game;
        private static Field? field;
        private static void Initialize()
        {
            Scenes = new List<Scene>();

            font = new Font(Path.Combine(Directory.GetCurrentDirectory(), "Assets") + "\\Fonts\\PF.ttf");

            //Menu
            #region
            buttonStart = new Button(10, 100, "Start", font, new Color(76, 0, 32, 255));
            buttonStart.Click += ButtonStart_Click;
            buttonStart.Aimed += Button_Aimed;

            buttonSettings = new Button(10, 200, "Settings", font, new Color(76, 0, 32, 255));
            buttonSettings.Click += ButtonSettings_Click;
            buttonSettings.Aimed += Button_Aimed;

            buttonQuit = new Button(10, 300, "Quit", font, new Color(76, 0, 32, 255));
            buttonQuit.Click += Close;
            buttonQuit.Aimed += Button_Aimed;

            labelMenu = new Label(300, 300, "Snake Game", font);

            menu = new Scene("Menu", new ElementUI[] { buttonQuit, buttonSettings, buttonStart, labelMenu },
                                   new GameObject[] { });
            #endregion

            //Settings
            #region
            buttonMenuBack = new Button(10, 10, "Back", font, new Color(100, 31, 21, 255));
            buttonMenuBack.Click += ButtonMenuBack_Click;
            buttonMenuBack.Aimed += Button_Aimed;

            buttonCounter = new Button(300, 300, "Click me", font, new Color(100, 31, 21, 255));
            buttonCounter.Click += ButtonCounter_Click; ;
            buttonCounter.Aimed += Button_Aimed;

            labelExample = new Label(500, 100, "Label", font);

            checkBox = new CheckBox(10, 100, "Vertical Sync", font);
            checkBox.Click += CheckBox_Click;

            settings = new Scene("Settings", new ElementUI[] { buttonMenuBack, checkBox, buttonCounter, labelExample },
                                   new GameObject[] { });
            #endregion

            //Game
            #region
            buttonGameBack = new Button(500, 620, "Back", font, new Color(100, 31, 21, 255));
            buttonGameBack.Click += ButtonGameBack_Click; ;
            buttonGameBack.Aimed += Button_Aimed;

            field = new Field(25, 25);

            settings = new Scene("Game", new ElementUI[] { buttonGameBack },
                                   new GameObject[] { field });
            #endregion

            CurrentScene = menu;
        }

        private static void ButtonGameBack_Click(object sender, EventArgs e)
        {
            SceneManager.LoadScene("Menu");
        }

        private static void ButtonCounter_Click(object sender, EventArgs e)
        {
            clickCount++;
            labelExample.Text = clickCount.ToString();
        }

        private static void CheckBox_Click(object sender, EventArgs e)
        {
            var e1 = e as ElementUIEventArgs;

            var window = e1.Target as Window;

            window?.SetVerticalSyncEnabled((sender as CheckBox).Value);
        }

        private static void ButtonMenuBack_Click(object sender, EventArgs e)
        {
            SceneManager.LoadScene("Menu");
        }

        private static void Close(object? sender, EventArgs e)
        {
            var e1 = e as ElementUIEventArgs;

            var window = e1.Target as Window;

            window?.Close();
        }

        private static void ButtonStart_Click(object? sender, EventArgs e)
        {
            SceneManager.LoadScene("Game");
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
