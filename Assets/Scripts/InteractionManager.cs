using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public PlayerProgression playerProgression;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Artifact"))
        {
            playerProgression.explorationPoints += 1;
            playerProgression.AddPoints("Curiosity", 1);
            Debug.Log("Exploration Points: " + playerProgression.explorationPoints);
        }
        else if (other.CompareTag("NPC"))
        {
            playerProgression.interactionPoints += 1;
            playerProgression.AddPoints("Social", 1);
            Debug.Log("Interaction Points: " + playerProgression.interactionPoints);
        }
        else if (other.CompareTag("AptitudeTest"))
        {
            playerProgression.aptitudePoints += 1;
            playerProgression.AddPoints("Intellect", 1);
            Debug.Log("Aptitude Points: " + playerProgression.aptitudePoints);
        }
        else if (other.CompareTag("Combat"))
        {
            playerProgression.AddPoints("Strength", 1);
            Debug.Log("Strength Points: " + playerProgression.strengthPoints);
        }
    }
}
