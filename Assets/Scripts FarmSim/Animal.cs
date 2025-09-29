using UnityEngine;

public enum FoodType
{
    Hay,        // วัวชอบ
    Grain,      // ไก่ชอบ
    Carrot, // ของสัตว์ใหม่
    RottenFood,
    AnimalFood
}
public abstract class Animal : MonoBehaviour
{
    
    //Fields
    private string name;
    private int hunger;
    private int happiness;
    //Properties
    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                name = "Unknown";
            }
            else
            {
                name = value;
            }
        }
    }
    public int Hunger
        {
            get { return hunger; }
            private set { hunger = Mathf.Clamp(value, 0, 100); }
        }
    public int Happiness
        {
            get { return happiness; }
            private set { happiness = Mathf.Clamp(value, 0, 100); }
        }
        
    protected FoodType PreferedFood { get; private set; }

    public void Init(string name, FoodType food)
        {
            this.Name = string.IsNullOrEmpty(name) ? "Unknown" : name;
            this.Hunger = 50;
            this.Happiness = 50;
            this.PreferedFood = food;
        }
    
    public void AdjustHunger(int setHunger)
    {
        Hunger += setHunger;
    }

    public void AdjustHappiness(int setHappiness)
    {
        Happiness += setHappiness;
    }
    
    public abstract void MakeSound();

    public void Feed(int amount)
        {
            AdjustHunger(-amount);
            AdjustHappiness(amount / 2);
            Debug.Log($"{Name} has been fed amount {amount}.");
            GetStatus();
        }

    public void Feed(FoodType food, int amount)
        {
            if (food == FoodType.RottenFood)
            {
                AdjustHappiness(-20);
                Debug.Log($"{Name} ate RottenFood! -20 Happiness");
            }
            else if (food == PreferedFood)
            {
                AdjustHunger(-amount);
                AdjustHappiness(15);
                Debug.Log($"{Name} ate favorite food {food}! +15 Happiness");
            }
            else if (food == FoodType.AnimalFood)
            {
                Feed(amount); 
            }
            else
            {
                AdjustHunger(-amount);
                Debug.Log($"{Name} ate {food}, but it's not favorite.");
            }
            GetStatus();
        }
    
    public abstract string Produce();
    
    public virtual void GetStatus()
    {
        Debug.Log($"Name : {Name}, Hunger : {Hunger}, Happiness : {Happiness}");
    }
}
