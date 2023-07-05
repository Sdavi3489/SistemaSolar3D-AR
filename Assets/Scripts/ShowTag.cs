using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTag : MonoBehaviour
{

    public GameObject showInfo;
    //public Image spriteImage;
    private bool isSpriteVisible = false;

    public void ToggleSprite()
    {
        isSpriteVisible = !isSpriteVisible;

        showInfo.SetActive(isSpriteVisible);
    }
    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
