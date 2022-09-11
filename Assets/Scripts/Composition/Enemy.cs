namespace Composition
{
    public class Enemy
    {
        public GameObject GameObject { private set; get; }
        public Life Health { private set; get; }
        public Enemy()
        {
            GameObject = new GameObject();
            Health = new Life();
        }

        public void Shoot(){}

    }
}