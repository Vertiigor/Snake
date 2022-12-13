using Snake.Fundamentals;

namespace Snake.Scenes.Managment
{
    public static class SceneManager
    {
        /// <summary>
        /// Loads scene that was registered.
        /// </summary>
        /// <param name="sceneName">Scene's name.</param>
        public static void LoadScene(string sceneName)
        {
                Game.CurrentScene = Game.Scenes.First(s => s.Name == sceneName);
        }
    }
}
