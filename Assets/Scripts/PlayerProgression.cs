using UnityEngine;

public class PlayerProgression : MonoBehaviour
{
    public Archetype archetype;
    public int explorationPoints;
    public int interactionPoints;
    public int aptitudePoints;
    public int intellectPoints;
    public int strengthPoints;
    public int curiosityPoints;
    public int socialPoints;

    void Update()
    {
        // Lógica para atualizar pontos com base nas ações do jogador
        // Exemplo: explorationPoints += 1;

        CheckForAbilityUnlock();
    }

    void CheckForAbilityUnlock()
    {
        if (explorationPoints >= 10 && archetype.archetype == Archetype.ArchetypeType.Explorer)
        {
            archetype.UnlockAbility();
        }
        else if (interactionPoints >= 10 && archetype.archetype == Archetype.ArchetypeType.SeekerOfKnowledge)
        {
            archetype.UnlockAbility();
        }
        else if (aptitudePoints >= 10 && archetype.archetype == Archetype.ArchetypeType.ConjurorOfPotential)
        {
            archetype.UnlockAbility();
        }
        // Adicionar outras condições para desbloquear habilidades com base nos pontos e arquétipos
    }

    public void AddPoints(string category, int points)
    {
        switch (category)
        {
            case "Intellect":
                intellectPoints += points;
                break;
            case "Strength":
                strengthPoints += points;
                break;
            case "Curiosity":
                curiosityPoints += points;
                break;
            case "Social":
                socialPoints += points;
                break;
        }
    }

    public void DetermineArchetype()
    {
        if (intellectPoints >= strengthPoints && intellectPoints >= curiosityPoints && intellectPoints >= socialPoints)
        {
            archetype.archetype = Archetype.ArchetypeType.SeekerOfKnowledge;
        }
        else if (strengthPoints >= intellectPoints && strengthPoints >= curiosityPoints && strengthPoints >= socialPoints)
        {
            archetype.archetype = Archetype.ArchetypeType.MasterOfConflict;
        }
        else if (curiosityPoints >= intellectPoints && curiosityPoints >= strengthPoints && curiosityPoints >= socialPoints)
        {
            archetype.archetype = Archetype.ArchetypeType.Explorer;
        }
        else if (socialPoints >= intellectPoints && socialPoints >= strengthPoints && socialPoints >= curiosityPoints)
        {
            archetype.archetype = Archetype.ArchetypeType.GuardianOfTradition;
        }
        else
        {
            archetype.archetype = Archetype.ArchetypeType.ConjurorOfPotential;
        }
        archetype.UnlockAbility();
    }
}
