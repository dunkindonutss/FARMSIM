using UnityEngine;

public abstract class Character : MonoBehaviour
{
   public string Name;
   protected int maxHealth;
   private int health;
   public int AttackPower;
   
   public int Health
   {
      get { return health; }
      set
      {
         if (value >= 0)
            health = value;
         else
            health = 0;
      }
   }
   
   public void Init(string characterName,int characterHealth,int characterAttackPower)
   {
      Name = characterName;
      Health = characterHealth;
      AttackPower = characterAttackPower;
   }

   public void TakeDamage(int damage)
   {
      //Health -= damage;
      //if (Health < 0) Health = 0;
      Health = Mathf.Clamp(Health - damage, 0, Health);
      Debug.Log($"{Name} takes damage {damage},Remaining HP : {Health}");
         
      
   }

   public bool IsAlive()
   {
      if (Health > 0)
      {
         Debug.Log("Character is Alive");
         return true;
      }
      else
      {
         Debug.Log("Character is Dead");
         return false;
      }
   }

   public void ShowStat()
   {
      Debug.Log($"Character {Name} is {IsAlive()},HP : {Health},ATK : {AttackPower}");
   }

   public abstract void Attack(Character target);
   
   public abstract void Attack(Character target,int bonusDamage);

}
