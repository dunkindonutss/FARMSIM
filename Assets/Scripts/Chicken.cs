using UnityEngine;

public class Chicken : MonoBehaviour
{
    private string name;
    private int hunger;
    private int happiness;
    private int egg;
    public string Name { get { return name; } set { name = value; } }
    public int Hunger { get { return hunger; } set 
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
    public int Happiness { get { return happiness; } set 
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
    public int Egg { get { return egg; } set { egg = value; } }

    public Chicken(string thisName, int setHunger, int setHappiness, int setEgg)
    {
       Name = thisName;
       Hunger = setHunger;
       Happiness = setHappiness;
       Egg = setEgg;
    }

    public void AdjustHunger(int setHunger)
    {
        Hunger = setHunger;
        GetStatus();
    }

    public void AdjustHappiness(int setHappiness)
    {
        Happiness = setHappiness;
        GetStatus();
    }

    public void MakeSound()
    {
        Debug.Log("Katak Katak !!");
    }

    public void Feed(string foodName)
    {
        Debug.Log($"You've Feeded {Name} with : {foodName}");
        Hunger -= 10;
        Happiness += 10;
        GetStatus();
    }

    public void GetStatus()
    {
        Debug.Log($"Name : {Name}, Hunger : {Hunger}, Happiness : {Happiness}, Egg : {Egg}");
    }

    public void Sleep()
    {
        Debug.Log($"{Name} is Sleeping");
        Hunger += 5;
        Happiness += 10;
        GetStatus();
    }
}
