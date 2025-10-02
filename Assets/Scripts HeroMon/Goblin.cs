using UnityEngine;

public class Goblin : Monster
{
    public override int LootReward => 5;

    public override void Roar()
    {
        Debug.Log($"Orc {name} ROAR SO FUNNY");
    }

    public void InitializeGoblin(string name)
    {
        base.Init(name,40,8);
    }

    public override void Attack(Character target)
    {
        target.TakeDamage(AttackPower);
        Debug.Log($"{Name} attacks {target.Name} with Quick Stab for {AttackPower} damage!");
    }

    public override void Attack(Character target, int bonusDamage)
    {
        int finalDamage = AttackPower += bonusDamage;
        target.TakeDamage(finalDamage);
        Debug.Log($"{Name} attacks {target.Name} with Ultra Quick Stab for {finalDamage} damage!");
    }
}
