using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class ControladorText : MonoBehaviour, ITrackableEventHandler
{
    public Text initialText; // Referência ao objeto de texto inicial
    private TrackableBehaviour trackableBehaviour; // Referência ao comportamento do marcador

    private void Start()
    {
        trackableBehaviour = GetComponent<TrackableBehaviour>();

        if (trackableBehaviour)
        {
            trackableBehaviour.RegisterTrackableEventHandler(this);
        }

        initialText.enabled = true; // Exibir o texto inicial no início
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            initialText.enabled = false; // Ocultar o texto inicial quando o marcador é detectado
        }
        else
        {
            initialText.enabled = true; // Exibir o texto inicial quando o marcador é perdido
        }
    }
}
