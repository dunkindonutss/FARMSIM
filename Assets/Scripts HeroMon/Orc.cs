using UnityEngine;

public class Orc : Monster
{
    public override int LootReward => 10;

    public override void Roar()
    {
        Debug.Log($"Orc {name} ROAR FIERCELY");
    }

    public void InitializeOrc(string name)
    {
        base.Init(name,60,12);
    }

    public override void Attack(Character target)
    {
        target.TakeDamage(AttackPower); 
        Debug.Log($"{Name} attacks {target.Name} with Heavy Slash for {AttackPower} damage!");
    }

    public override void Attack(Character target, int bonusDamage)
    {
        int finalDamage = AttackPower += bonusDamage;
        target.TakeDamage(finalDamage);
        Debug.Log($"{Name} attacks {target.Name} with Ultra Heavy Slash for {finalDamage} damage!");
    }
}
