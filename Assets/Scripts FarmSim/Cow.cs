using UnityEngine;

public class Cow : Animal
{
    private float Milk { get; set; }

    public override void MakeSound()
    {
        Debug.Log($"{Name} says Moo Moooo!");
    }

    public override string Produce()
    {
        if (Happiness > 70)
        {
            Milk = Happiness / 10f;
            return $"{Name} produced {Milk} units of Milk.";
        }
        return $"{Name} is not happy enough to produce milk.";
    }
}
