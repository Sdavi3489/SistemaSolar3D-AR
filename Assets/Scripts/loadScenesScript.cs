using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScenesScript : MonoBehaviour
{
    public void CarregarCena(string cena){
        SceneManager.LoadScene(cena);
    }

    public void Quit(){
        Application.Quit();
    }
}
