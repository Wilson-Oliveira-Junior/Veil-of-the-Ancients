using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string characterName;
    public int age;
    public Archetype archetype;
    public List<Ability> abilities;
    private WorldManager worldManager;
    private ArchetypeDiscovery archetypeDiscovery;

    void Start()
    {
        age = 10; // Começa como criança
        abilities = new List<Ability>();
        worldManager = FindObjectOfType<WorldManager>();
        archetypeDiscovery = GetComponent<ArchetypeDiscovery>();
        worldManager.DisplayWorldInfo();
    }

    void Update()
    {
        // ...código para atualizar o personagem...
    }

    public void LearnAbility(Ability newAbility)
    {
        abilities.Add(newAbility);
    }

    public void TrainAbility(Ability ability)
    {
        ability.Upgrade();
    }
}
