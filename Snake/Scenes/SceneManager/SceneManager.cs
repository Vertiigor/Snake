﻿using Snake.Fundamentals;

namespace Snake.Scenes.SceneManager
{
    public static class SceneManager
    {
        public static void LoadScene(string sceneName)
        {
                Game.CurrentScene = Game.Scenes.First(s => s.Name == sceneName);
        }
    }
}