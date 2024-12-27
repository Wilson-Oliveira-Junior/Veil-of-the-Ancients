using UnityEngine;

public class AptitudeTest : MonoBehaviour
{
    public string testName;
    public string description;
    public PlayerProgression playerProgression;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartTest();
        }
    }

    void StartTest()
    {
        // Lógica para iniciar o teste de aptidão
        Debug.Log("Teste de aptidão iniciado: " + testName);
        // Adicionar lógica para avaliar a performance do jogador
        playerProgression.AddPoints("Intellect", 1);
    }
}
