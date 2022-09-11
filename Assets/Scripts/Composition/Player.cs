namespace Composition
{
    public class Player
    {
        public string Name { private set; get; }
        public GameObject GameObject { private set; get; }
        public Life Health { private set; get; }
        public Player(string InName)
        {
            Name = InName;
            GameObject = new GameObject();
            Health = new Life();
        }

        public void Shoot(){}

    }
}