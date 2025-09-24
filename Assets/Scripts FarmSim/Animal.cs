using UnityEngine;

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
        private set
        {
            if (value >= 0 && value < 50)
            {
                hunger = value;
            }
            else
            {
                hunger = 0;
            }
        }
    }
    public int Happiness
    {
        get { return happiness; }
        private set
        {
            if (value >= 0 && value < 50)
            {
                happiness = value;
            }
            else
            {
                happiness = 0;
            }
        }
    }

    public void Init(string name, int hunger, int happiness)
    {
        this.Name = name;
        this.Hunger = hunger;
        this.Happiness = happiness;
    }
    
    public void AdjustHunger(int setHunger)
    {
        Hunger += setHunger;
    }

    public void AdjustHappiness(int setHappiness)
    {
        Happiness += setHappiness;
    }
    
    public virtual void MakeSound()
    {
        Debug.Log("Animal is Making Sound");
    }

    public void Feed(int amount)
    {
        AdjustHunger(amount);
        Debug.Log($"You've Feeded {Name} : {amount} Amount");
        GetStatus();
    }

    public void Feed(string foodName, int amount)
    {
        AdjustHunger(amount);
        Debug.Log($"You've Feeded {Name} With {foodName} : {amount} Amount");
        GetStatus();
    }
    
    public virtual void GetStatus()
    {
        Debug.Log($"Name : {Name}, Hunger : {Hunger}, Happiness : {Happiness}");
    }
}
