using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanciaTags : MonoBehaviour
{
    private float distancia;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("ARCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(-0.15f, 0.15f, 0.15f);
        transform.LookAt(cam.transform);
        /*distancia = Vector3.Distance(cam.transform.position, transform.position);
        if(distancia < 150)
        {
            transform.LookAt(cam.transform);
            transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
        }
        else
        {
            transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
        }*/

    }
}
