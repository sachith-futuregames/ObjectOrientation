namespace ClassInheritance
{
    public class Main
    {
        public void Run()
        {
            var player = new Player();
            player.SetName("Sachit");

            var enemy = new Enemy();

            var obstacle = new Obstacle();
            obstacle.MoveTo(new Vector3(10, 10, 0));

            player.MoveTo(new Vector3(10, 20, 0));
            enemy.MoveTo(new Vector3(20, 10, 0));

            player.Shoot();
            enemy.TakeDamage(30);

            enemy.Shoot();
            player.TakeDamage(25);
            
            enemy.Shoot();
            obstacle.Destroy();
        }
    }
}