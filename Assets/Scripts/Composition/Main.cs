namespace Composition
{
    public class Main
    {
        public void Run()
        {
            var player = new Player("Sachit");

            var enemy = new Enemy();

            var obstacle = new Obstacle();
            obstacle.GameObject.MoveTo(new Vector3(10, 10, 0));

            player.GameObject.MoveTo(new Vector3(10, 20, 0));
            enemy.GameObject.MoveTo(new Vector3(20, 10, 0));

            player.Shoot();
            enemy.Health.TakeDamage(30);

            enemy.Shoot();
            player.Health.TakeDamage(25);
            
            enemy.Shoot();
            obstacle.Destroy();
        }
    }
}