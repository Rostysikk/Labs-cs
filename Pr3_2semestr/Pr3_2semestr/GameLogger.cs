using System;

class GameLogger
{
    public void Subscribe(Player player)
    {
        player.OnDamageTaken += Log;
    }

    private void Log(int damage, int hp)
    {
        Console.WriteLine($"[Log] Damage: {damage}, Current HP: {hp}");
    }
}