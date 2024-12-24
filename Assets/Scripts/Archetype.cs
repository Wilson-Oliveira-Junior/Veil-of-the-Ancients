using UnityEngine;

public class Archetype
{
    public string name;
    public Ability uniqueAbility;

    public Archetype(string name, Ability uniqueAbility)
    {
        this.name = name;
        this.uniqueAbility = uniqueAbility;
    }

    public Ability GetUniqueAbility()
    {
        return uniqueAbility;
    }
}
