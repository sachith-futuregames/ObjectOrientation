namespace Composition
{
    public class Life
    {
        private int _life = 100;

        public void TakeDamage(int InDamage)
        {
            _life -= InDamage;
        }

        public int GetLife()
        {
            return _life;
        }
    }
}