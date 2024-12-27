using UnityEngine;

public class ArtifactDiscovery : MonoBehaviour
{
    public string artifactName;
    public string description;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DiscoverArtifact();
        }
    }

    void DiscoverArtifact()
    {
        // Lógica para registrar a descoberta do artefato
        Debug.Log("Artefato descoberto: " + artifactName);
        // Adicionar lógica para atualizar o estado do jogador ou inventário
    }
}
