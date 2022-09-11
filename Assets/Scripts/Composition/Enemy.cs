namespace Composition
{
    public class Enemy
    {
        public GameObject GameObject { private set; get; }
        public Gun Gun { private set; get; }
        public Life Health { private set; get; }
        public Enemy()
        {
            GameObject = new GameObject();
            Gun = new Gun();
            Health = new Life();
        }

        public void Shoot(){}

    }
}