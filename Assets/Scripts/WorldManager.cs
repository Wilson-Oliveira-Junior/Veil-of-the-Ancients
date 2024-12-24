using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    public string worldOrigin;
    public List<string> pastEras;
    public string currentEra;
    public string mainCity;
    public List<string> factions;
    public List<string> deities;
    public List<string> uniqueAbilities;

    void Start()
    {
        InitializeWorld();
    }

    void InitializeWorld()
    {
        worldOrigin = "Em Aberto"; // Origem do mundo
        pastEras = new List<string>
        {
            "Era dos Dragões",
            "Era da Magia (Netheril)",
            "Era dos Heróis"
        };
        currentEra = "Era da Nova Magia";
        mainCity = "Baldur's Gate";
        factions = new List<string>
        {
            "Os Tecnicistas",
            "Os Arcânicos",
            "Os Neutros"
        };
        deities = new List<string>
        {
            "Mystra",
            "Lathander",
            "Savras",
            "Azuth",
            "Gond"
        };
        uniqueAbilities = new List<string>
        {
            "Appraisal",
            "Mana Overflow",
            "Beast Tamer",
            "Battle Instinct",
            "Second Wind",
            "Lucky Soul",
            "Shadow Meld",
            "Arcane Affinity",
            "Weapon Bond",
            "Aura Reader",
            "Enhanced Vision"
        };
    }

    public void DisplayWorldInfo()
    {
        Debug.Log("Origem do Mundo: " + worldOrigin);
        Debug.Log("Eras Passadas: " + string.Join(", ", pastEras));
        Debug.Log("Era Atual: " + currentEra);
        Debug.Log("Cidade Principal: " + mainCity);
        Debug.Log("Facções: " + string.Join(", ", factions));
        Debug.Log("Deuses: " + string.Join(", ", deities));
        Debug.Log("Habilidades Únicas: " + string.Join(", ", uniqueAbilities));
    }

    public void TriggerChildhoodEvent(Character character)
    {
        // Implementar eventos de infância que influenciam o arquétipo
        // Exemplo: Interações com NPCs, desafios, etc.
    }
}
