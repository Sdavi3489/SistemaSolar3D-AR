using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistancedVisibility : MonoBehaviour
{
    public Transform target; // Referência ao marcador de AR
    public float maxDistance = 10f; // Distância máxima para exibir o objeto

    private Renderer objectRenderer;

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        // Verificar a distância entre a câmera e o marcador de AR
        float distance = Vector3.Distance(transform.position, target.position);

        // Ativar ou desativar o objeto 3D com base na distância
        objectRenderer.enabled = distance <= maxDistance;
    }
}
