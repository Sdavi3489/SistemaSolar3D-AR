using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelPause : MonoBehaviour
{
    public GameObject pausePanel;
    
    public void Pause(){
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Continue(){
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }
}
