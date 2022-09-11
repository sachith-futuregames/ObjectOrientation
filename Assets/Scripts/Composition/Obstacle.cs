namespace Composition
{
    public class Obstacle
    {
        public GameObject GameObject { private set; get; }
        public Obstacle()
        {
            GameObject = new GameObject();
        }

        public void Destroy(){}

    }
}