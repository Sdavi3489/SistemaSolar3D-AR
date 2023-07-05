using UnityEngine;
using UnityEngine.UI;

public class ARTextController : MonoBehaviour
{
    //public MeshRenderer objectRenderer; // Referência ao Mesh Renderer do objeto 3D
    public GameObject textObject; // Referência ao objeto de texto inicial
    public SpriteRenderer tags; // Referência ao sistema solar ou outros objetos que foram criados pelo blender

    private void Start()
    {
        textObject.SetActive(true); // Exibir o texto inicial no início
        //objectRenderer.enabled = false; // Ocultar o objeto 3D no início
        //tags.enabled = false;
    }

    private void Update()
    {
        if (tags.isVisible) // Verificar se o objeto 3D está visível na câmera
        {
            textObject.SetActive(false); // Ocultar o texto inicial quando o objeto 3D estiver renderizado
        }
        else
        {
            textObject.SetActive(true); // Exibir o texto inicial quando o objeto 3D não estiver renderizado
        }
    }
}
