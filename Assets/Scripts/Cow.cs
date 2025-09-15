using UnityEngine;

public class Cow : MonoBehaviour
{
    private string name;
    private int hunger;
    private int happiness;
    private int milk;
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
    public int Milk { get { return milk; } set { milk = value; } }
    
    public Cow(string thisName, int setHunger, int setHappiness, int setMilk)
    {
        Name = thisName;
        Hunger = setHunger;
        Happiness = setHappiness;
        Milk = setMilk;
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
        Debug.Log("Moo Mooo !!");
        Happiness += 10;
        GetStatus();
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
        Debug.Log($"Name : {Name}, Hunger : {Hunger}, Happiness : {Happiness}, Milk : {Milk}");
    }

    public void Sleep()
    {
        Debug.Log($"{Name} is Sleeping");
    }
}
