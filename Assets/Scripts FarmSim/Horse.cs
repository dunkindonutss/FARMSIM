using UnityEngine;

public class Horse : Animal
{
    private int HorsePoop { get; set; }

    public override void MakeSound()
    {
        Debug.Log($"{Name} says HEE HEE!");
    }

    public override string Produce()
    {
        HorsePoop = Happiness / 5;
        return $"{Name} produced {HorsePoop} HorsePoop.";
    }
}
