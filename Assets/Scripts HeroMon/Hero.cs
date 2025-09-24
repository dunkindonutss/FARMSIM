using UnityEngine;

public class Hero : Character
{
   public int Gold;

   public void EarnGold(int amount)
   {
      Gold += amount;
   }

   public override void Attack(Character target)
   {
      Attack(target);
      Debug.Log($"Hero {Name} Slash {target.Name} for {AttackPower} Dmg !");
   }

   public override void Attack(Character target, int bonusDamage)
   {
      int damage = AttackPower + bonusDamage;
      target.TakeDamage(damage);
      Debug.Log($"Hero {Name} Use Special Attack to {target.Name} for {damage} Dmg !");
   }

   public void Heal(int healAmount)
   {
      Health = Mathf.Clamp(Health + healAmount, 0, maxHealth);
   }
}
