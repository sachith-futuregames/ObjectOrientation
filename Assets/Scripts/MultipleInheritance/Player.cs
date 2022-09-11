namespace MultipleInheritance
{
    public class Player : GameObject, ILife
    {
        public string Name { get; set; }
        public int Life { get; set; } = 100;

        public void TakeDamage(int InDamage)
        {
            Life -= InDamage;
        }
        public void Shoot() {}
    }
}