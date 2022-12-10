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

                if (element is Drawable)
                    target.Draw(element as Drawable);
            }

            foreach (GameObject element in gameObjects)
            {
                
            }
        }
    }
}
