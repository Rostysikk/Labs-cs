using System;

class AchievementSystem
{
    public void Subscribe(Player player)
    {
        player.OnDamageTaken += CheckAchievements;
    }

    private void CheckAchievements(int damage, int hp)
    {
        if (hp <= 50)
            Console.WriteLine("[Achievement] Half Health");

        if (hp <= 0)
            Console.WriteLine("[Achievement] First Death");
    }
}