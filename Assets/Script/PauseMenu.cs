using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject gb;
    [SerializeField] private GameObject penghilang;

    public void lanjut(){
        gb.SetActive(false);
        Time.timeScale = 1f;
        penghilang.SetActive(true);
    }

    public void balik(){
        penghilang.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
        
    }
}
