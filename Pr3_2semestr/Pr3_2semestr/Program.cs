class Program
{
    static void Main()
    {
        var player = new Player(100);

        var ui = new UIHealthBar();
        var sound = new SoundSystem();
        var achievement = new AchievementSystem();
        var logger = new GameLogger();

        ui.Subscribe(player);
        sound.Subscribe(player);
        achievement.Subscribe(player);
        logger.Subscribe(player);

        player.TakeDamage(20);
        player.TakeDamage(30);
        player.TakeDamage(40);
        player.TakeDamage(20);
    }
}