using System;

class SoundSystem
{
    public void Subscribe(Player player)
    {
        player.OnDamageTaken += PlaySound;
    }

    private void PlaySound(int damage, int hp)
    {
        Console.WriteLine("[Sound] Damage sound effect");

        if (hp <= 20)
            Console.WriteLine("[Sound]  Critical condition!");
    }
}