namespace ClassInheritance
{
    public class Player : GameObject
    {
        private string _name;
        private int _life = 100;

        public void TakeDamage(int inDamage)
        {
            _life -= inDamage;
        }

        public int GetLife()
        {
            return _life;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string inName)
        {
            _name = inName;
        }

        public void Shoot(){}

    }
}