using UnityEngine;

public class Archetype : MonoBehaviour
{
    public enum ArchetypeType
    {
        GuardianOfTradition,
        SeekerOfKnowledge,
        Explorer,
        ConjurorOfPotential,
        MasterOfConflict
    }

    public ArchetypeType archetype;
    public string uniqueAbility;

    void Start()
    {
        switch (archetype)
        {
            case ArchetypeType.GuardianOfTradition:
                uniqueAbility = "Defesa Ancestral";
                break;
            case ArchetypeType.SeekerOfKnowledge:
                uniqueAbility = "Percepção Aumentada";
                break;
            case ArchetypeType.Explorer:
                uniqueAbility = "Intuição de Sobrevivência";
                break;
            case ArchetypeType.ConjurorOfPotential:
                uniqueAbility = "Manipulação de Mana";
                break;
            case ArchetypeType.MasterOfConflict:
                uniqueAbility = "Força Bruta";
                break;
        }
    }

    public void UnlockAbility()
    {
        Debug.Log("Habilidade única desbloqueada: " + uniqueAbility);
        // Adicionar lógica para aplicar a habilidade única ao personagem
    }
}
