using UnityEngine;

public class Ability
{
    public string name;
    public int level;

    public Ability(string name)
    {
        this.name = name;
        this.level = 1;
    }

    public void Upgrade()
    {
        level++;
        // ...código para melhorar a habilidade...
    }
}

// Exemplos de habilidades únicas
public static class UniqueAbilities
{
    public static Ability Appraisal = new Ability("Appraisal");
    public static Ability ManaOverflow = new Ability("Mana Overflow");
    public static Ability BeastTamer = new Ability("Beast Tamer");
    public static Ability BattleInstinct = new Ability("Battle Instinct");
    public static Ability SecondWind = new Ability("Second Wind");
    public static Ability LuckySoul = new Ability("Lucky Soul");
    public static Ability ShadowMeld = new Ability("Shadow Meld");
    public static Ability ArcaneAffinity = new Ability("Arcane Affinity");
    public static Ability WeaponBond = new Ability("Weapon Bond");
    public static Ability AuraReader = new Ability("Aura Reader");
    public static Ability EnhancedVision = new Ability("Enhanced Vision");
    // ...adicione mais habilidades conforme necessário...
}
