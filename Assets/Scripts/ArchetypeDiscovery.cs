using System.Collections.Generic;
using UnityEngine;

public class ArchetypeDiscovery : MonoBehaviour
{
    private Character character;
    private WorldManager worldManager;
    private bool archetypeDiscovered = false;

    void Start()
    {
        character = GetComponent<Character>();
        worldManager = FindObjectOfType<WorldManager>();
        StartChildhoodEvents();
    }

    void StartChildhoodEvents()
    {
        // Iniciar eventos de infância que influenciam o arquétipo
        TriggerEvent1();
        TriggerEvent2();
        // Adicione mais eventos conforme necessário
    }

    void TriggerEvent1()
    {
        // Exemplo de evento de infância: Encontro com um estranho
        Debug.Log("Evento de Infância: Encontro com um estranho");
        // Decisão do jogador
        int choice = Random.Range(0, 2); // Simulação de escolha do jogador
        if (choice == 0)
        {
            Debug.Log("Você seguiu o estranho e aprendeu magia proibida.");
            character.abilities.Add(UniqueAbilities.ArcaneAffinity);
        }
        else
        {
            Debug.Log("Você ajudou um inocente e ganhou a confiança de uma figura importante.");
            character.abilities.Add(UniqueAbilities.AuraReader);
        }
    }

    void TriggerEvent2()
    {
        // Exemplo de evento de infância: Conflito com outros jovens
        Debug.Log("Evento de Infância: Conflito com outros jovens");
        // Decisão do jogador
        int choice = Random.Range(0, 3); // Simulação de escolha do jogador
        if (choice == 0)
        {
            Debug.Log("Você lutou agressivamente.");
            character.abilities.Add(UniqueAbilities.BattleInstinct);
        }
        else if (choice == 1)
        {
            Debug.Log("Você usou astúcia para enganar o inimigo.");
            character.abilities.Add(UniqueAbilities.LuckySoul);
        }
        else
        {
            Debug.Log("Você tentou resolver a disputa sem violência.");
            character.abilities.Add(UniqueAbilities.SecondWind);
        }
    }

    void Update()
    {
        if (!archetypeDiscovered && character.age >= 12)
        {
            DiscoverArchetype();
        }
    }

    void DiscoverArchetype()
    {
        // Realizar o ritual de despertar para descobrir o arquétipo e a habilidade única
        character.archetype = ArchetypeManager.GetRandomArchetype();
        character.abilities.Add(character.archetype.GetUniqueAbility());
        archetypeDiscovered = true;
        Debug.Log("Arquetipo descoberto: " + character.archetype.name);
        Debug.Log("Habilidade única: " + character.archetype.GetUniqueAbility().name);
    }
}
