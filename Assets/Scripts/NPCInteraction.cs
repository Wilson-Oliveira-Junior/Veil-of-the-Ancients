using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    public string npcName;
    public string[] dialogueLines;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartDialogue();
        }
    }

    void StartDialogue()
    {
        // Lógica para iniciar o diálogo com o NPC
        foreach (string line in dialogueLines)
        {
            Debug.Log(npcName + ": " + line);
        }
        // Adicionar lógica para atualizar o estado do jogador ou história
    }
}
