namespace Composition
{
    public class Player
    {
        public string Name { private set; get; }
        public GameObject GameObject { private set; get; }
        public Gun Gun { private set; get; }
        public Life Health { private set; get; }
        public Player(string InName)
        {
            Name = InName;
            GameObject = new GameObject();
            Gun = new Gun();
            Health = new Life();
        }

        public void Shoot(){}

    }
}