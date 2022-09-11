namespace MultipleInheritance
{
    public class Enemy : GameObject, ILife
    {
        public int Life { get; set; } = 50;

        public void TakeDamage(int InDamage)
        {
            Life -= InDamage;
        }
        public void Shoot() {}
    }
}