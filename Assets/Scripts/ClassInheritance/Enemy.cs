namespace ClassInheritance
{
    public class Enemy : GameObject
    {
        private int _life = 100;

        public void TakeDamage(int inDamage)
        {
            _life -= inDamage;
        }

        public int GetLife()
        {
            return _life;
        }

        public void Shoot(){}     
    }
}