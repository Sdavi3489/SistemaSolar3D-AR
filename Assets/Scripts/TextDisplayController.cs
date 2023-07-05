using UnityEngine;
using UnityEngine.UI;

public class TextDisplayController : MonoBehaviour
{
    public Text initialText; // Referência ao objeto de texto inicial

    private float displayTime = 5f; // Tempo de exibição do texto (em segundos)
    private float timer = 0f; // Contador de tempo

    private void Start()
    {
        initialText.enabled = true; // Exibir o texto inicial no início
    }

    private void Update()
    {
        timer += Time.deltaTime; // Atualizar o contador de tempo

        if (timer >= displayTime) // Verificar se o tempo de exibição foi atingido
        {
            initialText.enabled = false; // Ocultar o texto inicial
        }
    }
}
