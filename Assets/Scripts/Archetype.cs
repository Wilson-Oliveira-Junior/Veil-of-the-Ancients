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
    private int abilityLevel = 1;

    void Start()
    {
        DetermineArchetype();
        DetermineUniqueAbility();
    }

    void DetermineArchetype()
    {
        // Exemplo de perguntas e respostas
        int scoreGuardian = 0;
        int scoreSeeker = 0;
        int scoreExplorer = 0;
        int scoreConjuror = 0;
        int scoreMaster = 0;

        int affinityMagic = 0;
        int affinityTechnology = 0;
        int affinityPhysical = 0;

        // Novas perguntas reflexivas
        if (AskQuestion("Pense em um momento em que você estava sozinho(a). Como você ocupou sua mente?", new string[] { "Observando as pequenas coisas ao meu redor e tentando entender como tudo funciona.", "Pensando em como melhorar algo que vi ou fiz recentemente.", "Relembrando um desafio difícil e como superei isso com esforço." }) == 0)
            scoreSeeker++;
        if (AskQuestion("Quando você olha para o pôr do sol ou o horizonte distante, o que mais o impressiona?", new string[] { "A profundidade das cores e a sensação de algo maior.", "O padrão de como a luz e as sombras se conectam entre si.", "A força que move o mundo, como ventos e ondas." }) == 1)
            scoreExplorer++;
        if (AskQuestion("Alguém em sua vida lhe ensinou algo valioso. O que foi?", new string[] { "Que há mais verdades escondidas do que conseguimos enxergar.", "Que cada problema tem uma solução, mesmo as mais complicadas.", "Que não importa o tamanho do obstáculo, persistência vence." }) == 2)
            scoreMaster++;
        if (AskQuestion("Você se lembra de um objeto que marcou sua infância. O que ele representava para você?", new string[] { "Um enigma que me fazia sonhar com o desconhecido.", "Uma ferramenta ou peça que sempre estava comigo.", "Algo simples, mas que me ajudava em momentos de necessidade." }) == 0)
            scoreConjuror++;
        if (AskQuestion("Você está caminhando e algo completamente inesperado acontece. Qual seria sua reação instintiva?", new string[] { "Paro e tento entender o que está realmente acontecendo.", "Tento interagir com aquilo, mesmo sem saber exatamente como.", "Uso o que tenho disponível para proteger ou enfrentar o que vier." }) == 2)
            scoreGuardian++;
        if (AskQuestion("Quando você ouve uma boa história, qual parte geralmente prende sua atenção?", new string[] { "O mistério e os segredos não ditos.", "As ideias criativas que resolvem problemas complexos.", "Os momentos em que personagens enfrentam perigos diretamente." }) == 0)
            scoreSeeker++;
        if (AskQuestion("Você chega a uma bifurcação em uma estrada desconhecida. Como decide qual caminho seguir?", new string[] { "Observo os sinais ao redor e tento deduzir qual caminho parece mais seguro.", "Analiso as marcas no chão ou sinais de uso para escolher o caminho mais lógico.", "Escolho aquele que parece mais desafiador ou interessante." }) == 1)
            scoreExplorer++;
        if (AskQuestion("Quando você sonha, qual tema parece se repetir mais?", new string[] { "Lugares misteriosos e cheios de símbolos que não consigo entender.", "Construções ou mecanismos complexos que funcionam de formas estranhas.", "Momentos em que estou lutando ou correndo, como se estivesse protegendo algo." }) == 0)
            scoreConjuror++;
        if (AskQuestion("Qual o pensamento que geralmente faz você começar seu dia com mais energia?", new string[] { "O que posso descobrir de novo hoje?", "Como posso fazer algo melhor ou mais útil?", "Que desafios irei superar hoje?" }) == 2)
            scoreMaster++;
        if (AskQuestion("Quando você sente mais paz consigo mesmo(a)?", new string[] { "Quando estou cercado(a) por silêncio e mistério.", "Quando estou criando algo útil ou solucionando um problema.", "Quando estou me movimentando ou em ação, enfrentando desafios." }) == 0)
            scoreSeeker++;

        // Determinar o arquétipo com base na pontuação
        int maxScore = Mathf.Max(scoreGuardian, scoreSeeker, scoreExplorer, scoreConjuror, scoreMaster);
        if (maxScore == scoreGuardian)
            archetype = ArchetypeType.GuardianOfTradition;
        else if (maxScore == scoreSeeker)
            archetype = ArchetypeType.SeekerOfKnowledge;
        else if (maxScore == scoreExplorer)
            archetype = ArchetypeType.Explorer;
        else if (maxScore == scoreConjuror)
            archetype = ArchetypeType.ConjurorOfPotential;
        else if (maxScore == scoreMaster)
            archetype = ArchetypeType.MasterOfConflict;

        // Determinar afinidade com base na pontuação
        affinityMagic = scoreConjuror + scoreSeeker;
        affinityTechnology = scoreExplorer + scoreMaster;
        affinityPhysical = scoreGuardian + scoreMaster;
    }

    void DetermineUniqueAbility()
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

        // Adicionar lógica para ajustar a habilidade com base no contexto social
        if (AskQuestion("Você tem uma conexão forte com um irmão ou irmã que compartilha as mesmas ambições?", new string[] { "Sim", "Não" }) == 0)
        {
            if (archetype == ArchetypeType.GuardianOfTradition)
                uniqueAbility += " - Proteção Familiar";
            else if (archetype == ArchetypeType.SeekerOfKnowledge)
                uniqueAbility += " - Sabedoria Compartilhada";
        }

        if (AskQuestion("Você cresceu em um ambiente misterioso e oculto, envolto em segredos ou magia esquecida?", new string[] { "Sim", "Não" }) == 0)
        {
            if (archetype == ArchetypeType.ConjurorOfPotential)
                uniqueAbility += " - Magia Oculta";
            else if (archetype == ArchetypeType.Explorer)
                uniqueAbility += " - Descoberta de Segredos";
        }

        // Ajustar habilidade com base na afinidade final
        if (affinityMagic > affinityTechnology && affinityMagic > affinityPhysical)
        {
            uniqueAbility += " - Afinidade Mágica";
        }
        else if (affinityTechnology > affinityMagic && affinityTechnology > affinityPhysical)
        {
            uniqueAbility += " - Afinidade Tecnológica";
        }
        else if (affinityPhysical > affinityMagic && affinityPhysical > affinityTechnology)
        {
            uniqueAbility += " - Afinidade Física";
        }
    }

    public void EvolveAbility()
    {
        abilityLevel++;
        switch (uniqueAbility)
        {
            case "Defesa Ancestral":
                if (abilityLevel == 2)
                    uniqueAbility = "Forja Ancestral";
                else if (abilityLevel == 3)
                    uniqueAbility = "Chamada dos Ancestrais";
                else if (abilityLevel == 4)
                    uniqueAbility = "Guardião Eterno";
                break;
            case "Percepção Aumentada":
                if (abilityLevel == 2)
                    uniqueAbility = "Visão Profunda";
                else if (abilityLevel == 3)
                    uniqueAbility = "Conhecimento Absoluto";
                else if (abilityLevel == 4)
                    uniqueAbility = "Sabedoria Infinita";
                break;
            case "Intuição de Sobrevivência":
                if (abilityLevel == 2)
                    uniqueAbility = "Instinto de Caçador";
                else if (abilityLevel == 3)
                    uniqueAbility = "Mestre da Exploração";
                else if (abilityLevel == 4)
                    uniqueAbility = "Explorador Supremo";
                break;
            case "Manipulação de Mana":
                if (abilityLevel == 2)
                    uniqueAbility = "Controle Arcano";
                else if (abilityLevel == 3)
                    uniqueAbility = "Domínio do Mana";
                else if (abilityLevel == 4)
                    uniqueAbility = "Arquimago";
                break;
            case "Força Bruta":
                if (abilityLevel == 2)
                    uniqueAbility = "Poder Imparável";
                else if (abilityLevel == 3)
                    uniqueAbility = "Fúria do Conflito";
                else if (abilityLevel == 4)
                    uniqueAbility = "Titã da Batalha";
                break;
            case "Eco do Mana":
                if (abilityLevel == 2)
                    uniqueAbility = "Sussurros do Mana";
                else if (abilityLevel == 3)
                    uniqueAbility = "Ressonância Mágica";
                else if (abilityLevel == 4)
                    uniqueAbility = "Revelação Temporal";
                break;
            case "Transmutação Espontânea":
                if (abilityLevel == 2)
                    uniqueAbility = "Transmutação Avançada";
                else if (abilityLevel == 3)
                    uniqueAbility = "Alquimia Superior";
                else if (abilityLevel == 4)
                    uniqueAbility = "Transmutação Suprema";
                break;
            case "Chama Ancestral":
                if (abilityLevel == 2)
                    uniqueAbility = "Fogo Revelador";
                else if (abilityLevel == 3)
                    uniqueAbility = "Chama Secreta";
                else if (abilityLevel == 4)
                    uniqueAbility = "Fogo Eterno";
                break;
            case "Conexão Etérea":
                if (abilityLevel == 2)
                    uniqueAbility = "Comunicação Espiritual";
                else if (abilityLevel == 3)
                    uniqueAbility = "Sabedoria Ancestral";
                else if (abilityLevel == 4)
                    uniqueAbility = "Revelação Espiritual";
                break;
            case "Fluxo Temporal":
                if (abilityLevel == 2)
                    uniqueAbility = "Manipulação Temporal";
                else if (abilityLevel == 3)
                    uniqueAbility = "Controle do Tempo";
                else if (abilityLevel == 4)
                    uniqueAbility = "Domínio Temporal";
                break;
            case "Escudo Arcano":
                if (abilityLevel == 2)
                    uniqueAbility = "Escudo Mágico";
                else if (abilityLevel == 3)
                    uniqueAbility = "Barreira Arcana";
                else if (abilityLevel == 4)
                    uniqueAbility = "Escudo Reflexivo";
                break;
            case "Invocação Efêmera":
                if (abilityLevel == 2)
                    uniqueAbility = "Invocação Avançada";
                else if (abilityLevel == 3)
                    uniqueAbility = "Invocação Superior";
                else if (abilityLevel == 4)
                    uniqueAbility = "Invocação Suprema";
                break;
            case "Visão do Véu":
                if (abilityLevel == 2)
                    uniqueAbility = "Revelação do Véu";
                else if (abilityLevel == 3)
                    uniqueAbility = "Visão Entre Mundos";
                else if (abilityLevel == 4)
                    uniqueAbility = "Interação com o Véu";
                break;
            case "Ressurgência do Mana":
                if (abilityLevel == 2)
                    uniqueAbility = "Amplificação do Mana";
                else if (abilityLevel == 3)
                    uniqueAbility = "Restauração Completa";
                else if (abilityLevel == 4)
                    uniqueAbility = "Aumento de Energia";
                break;
            case "Linguagem Primordial":
                if (abilityLevel == 2)
                    uniqueAbility = "Decifração de Símbolos";
                else if (abilityLevel == 3)
                    uniqueAbility = "Compreensão Total";
                else if (abilityLevel == 4)
                    uniqueAbility = "Ativação de Selos";
                break;
            case "Engenharia Instintiva":
                if (abilityLevel == 2)
                    uniqueAbility = "Construção Avançada";
                else if (abilityLevel == 3)
                    uniqueAbility = "Criação Superior";
                else if (abilityLevel == 4)
                    uniqueAbility = "Engenharia Suprema";
                break;
            case "Manipulação de Energia":
                if (abilityLevel == 2)
                    uniqueAbility = "Controle de Energia";
                else if (abilityLevel == 3)
                    uniqueAbility = "Manipulação Avançada";
                else if (abilityLevel == 4)
                    uniqueAbility = "Domínio de Energia";
                break;
            case "Holografia Adaptativa":
                if (abilityLevel == 2)
                    uniqueAbility = "Projeção Complexa";
                else if (abilityLevel == 3)
                    uniqueAbility = "Holograma Realista";
                else if (abilityLevel == 4)
                    uniqueAbility = "Manipulação de Percepção";
                break;
            case "Interface Neural":
                if (abilityLevel == 2)
                    uniqueAbility = "Controle de Sistemas";
                else if (abilityLevel == 3)
                    uniqueAbility = "Interação Avançada";
                else if (abilityLevel == 4)
                    uniqueAbility = "Domínio Neural";
                break;
            case "Propulsão Inercial":
                if (abilityLevel == 2)
                    uniqueAbility = "Impulso Avançado";
                else if (abilityLevel == 3)
                    uniqueAbility = "Explosão Controlada";
                else if (abilityLevel == 4)
                    uniqueAbility = "Propulsão Suprema";
                break;
            case "Camuflagem Nanotecnológica":
                if (abilityLevel == 2)
                    uniqueAbility = "Disfarce Avançado";
                else if (abilityLevel == 3)
                    uniqueAbility = "Invisibilidade Temporária";
                else if (abilityLevel == 4)
                    uniqueAbility = "Projeção Camuflada";
                break;
            case "Sensorial Augmentado":
                if (abilityLevel == 2)
                    uniqueAbility = "Percepção Avançada";
                else if (abilityLevel == 3)
                    uniqueAbility = "Sentidos Aumentados";
                else if (abilityLevel == 4)
                    uniqueAbility = "Percepção Suprema";
                break;
            case "Dronificação":
                if (abilityLevel == 2)
                    uniqueAbility = "Drones de Combate";
                else if (abilityLevel == 3)
                    uniqueAbility = "Drones Especializados";
                else if (abilityLevel == 4)
                    uniqueAbility = "Exército de Drones";
                break;
            case "Reconstrução Automática":
                if (abilityLevel == 2)
                    uniqueAbility = "Reparo Avançado";
                else if (abilityLevel == 3)
                    uniqueAbility = "Revitalização Completa";
                else if (abilityLevel == 4)
                    uniqueAbility = "Reparo Instantâneo";
                break;
            case "Controle de Gravidade":
                if (abilityLevel == 2)
                    uniqueAbility = "Alteração de Gravidade";
                else if (abilityLevel == 3)
                    uniqueAbility = "Campo de Baixa Gravidade";
                else if (abilityLevel == 4)
                    uniqueAbility = "Domínio Gravitacional";
                break;
            case "Simbiose Energética":
                if (abilityLevel == 2)
                    uniqueAbility = "Dispositivos Temporários";
                else if (abilityLevel == 3)
                    uniqueAbility = "Ferramentas Únicas";
                else if (abilityLevel == 4)
                    uniqueAbility = "Amplificação Imersiva";
                break;
            case "Domínio do Fóton":
                if (abilityLevel == 2)
                    uniqueAbility = "Feixes de Luz";
                else if (abilityLevel == 3)
                    uniqueAbility = "Escudos de Luz";
                else if (abilityLevel == 4)
                    uniqueAbility = "Ataques Devastadores";
                break;
            case "Sinapse Arcano-Tecnológica":
                if (abilityLevel == 2)
                    uniqueAbility = "Interação com Sistemas";
                else if (abilityLevel == 3)
                    uniqueAbility = "Sintonização de Mentes";
                else if (abilityLevel == 4)
                    uniqueAbility = "Rede Mental";
                break;
            case "Circuitos Vivos":
                if (abilityLevel == 2)
                    uniqueAbility = "Formas Temporárias";
                else if (abilityLevel == 3)
                    uniqueAbility = "Circuitos Complexos";
                else if (abilityLevel == 4)
                    uniqueAbility = "Formas Permanentes";
                break;
            case "Amplificação Bioenergética":
                if (abilityLevel == 2)
                    uniqueAbility = "Restaurar Energia";
                else if (abilityLevel == 3)
                    uniqueAbility = "Amplificação Sustentada";
                else if (abilityLevel == 4)
                    uniqueAbility = "Vínculo Mágico";
                break;
            case "Descarga Eletromágica":
                if (abilityLevel == 2)
                    uniqueAbility = "Onda de Energia";
                else if (abilityLevel == 3)
                    uniqueAbility = "Explosão de Energia";
                else if (abilityLevel == 4)
                    uniqueAbility = "Destruição Massiva";
                break;
            case "Fabricação Efêmera":
                if (abilityLevel == 2)
                    uniqueAbility = "Objetos Temporários";
                else if (abilityLevel == 3)
                    uniqueAbility = "Fabricação Constante";
                else if (abilityLevel == 4)
                    uniqueAbility = "Construção Poderosa";
                break;
            case "Aura Regenerativa":
                if (abilityLevel == 2)
                    uniqueAbility = "Regeneração de Objetos";
                else if (abilityLevel == 3)
                    uniqueAbility = "Cura e Restauração";
                else if (abilityLevel == 4)
                    uniqueAbility = "Aura de Cura";
                break;
            case "Vínculo Simbiótico":
                if (abilityLevel == 2)
                    uniqueAbility = "Aprimoramento de Capacidades";
                else if (abilityLevel == 3)
                    uniqueAbility = "Fusão Temporária";
                else if (abilityLevel == 4)
                    uniqueAbility = "Ligação Permanente";
                break;
            case "Pulso Sincronizado":
                if (abilityLevel == 2)
                    uniqueAbility = "Efeitos Combinados";
                else if (abilityLevel == 3)
                    uniqueAbility = "Amplificação de Habilidades";
                else if (abilityLevel == 4)
                    uniqueAbility = "Onda de Energia";
                break;
        }
        Debug.Log("Habilidade evoluída para: " + uniqueAbility);
    }

    int AskQuestion(string question, string[] options)
    {
        // Implementar lógica para exibir a pergunta e opções ao jogador e retornar a resposta
        // Por enquanto, retornamos uma resposta aleatória para fins de exemplo
        return Random.Range(0, options.Length);
    }

    public void UnlockAbility()
    {
        Debug.Log("Habilidade única desbloqueada: " + uniqueAbility);
        // Adicionar lógica para aplicar a habilidade única ao personagem
    }
}
