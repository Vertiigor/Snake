using SFML.Graphics;
using Snake.Fundamentals;
using Snake.UI;

namespace Snake.Scenes
{
    public class Scene : IUpdatable
    {
        private List<ElementUI> UIelemnts;
        private List<GameObject> gameObjects;

        public string Name { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Scene's name.</param>
        /// <param name="elemnts">UI elements on the scene.</param>
        /// <param name="gameObjects">Game objects on the scene.</param>
        public Scene(string name, ElementUI[] elemnts, GameObject[] gameObjects)
        {
            Name = name;

            this.UIelemnts = new List<ElementUI>(elemnts);
            this.gameObjects = new List<GameObject>(gameObjects);

            Game.Scenes.Add(this);
        }

        public void Update(RenderTarget target)
        {
            foreach(ElementUI element in UIelemnts)
            {
                element.Update(target);
            }

            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Update(target);
            }
        }

        public void Draw(RenderTarget target)
        {
            foreach (ElementUI element in UIelemnts)
            {
                target.Draw(element);
            }

            foreach (GameObject gameObject in gameObjects)
            {
                target.Draw(gameObject);
            }
        }
    }
}
