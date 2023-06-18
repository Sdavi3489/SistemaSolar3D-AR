using UnityEngine;
using Vuforia;

public class btn_on : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbButtonObject;
    //public GameObject SolarSystem;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        vbButtonObject = GameObject.Find("btn_on");
        //SolarSystem = GameObject.Find("sistema_solar_3d");
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        animator.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Botão on pressionado");
        animator.Play("none");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Botão released");
        animator.Play("Take 001");
        
    }
}
