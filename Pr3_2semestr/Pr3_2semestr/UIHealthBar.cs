using System;

class UIHealthBar
{
    public void Subscribe(Player player)
    {
        player.OnDamageTaken += ShowHP;
    }

    private void ShowHP(int damage, int hp)
    {
        Console.WriteLine($"[UI] HP player: {hp}");
    }
}