using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayer : MonoBehaviour
{

    public GameObject lovis;
    public GameObject lovisA;
    public GameObject korvak;
    public GameObject korvakA;
    public GameObject canvaslovis;
    public GameObject canvaskorvak;
    public bool mainLov;
    public bool mainKor;

    void Start()
    {
        canvaslovis = GameObject.Find("UICanvas");
        canvaskorvak = GameObject.Find("UICanvas 1");
        lovis.GetComponent<PlayerMovement>().enabled = true;
        korvak.GetComponent<PlayerMovement>().enabled = false;
        korvak.GetComponent<Checkpoint>().enabled = false;
        korvak.GetComponentInChildren<Health>().enabled = false;
        canvaskorvak.SetActive(false);
        korvakA.GetComponent<AnimasiK>().enabled = false;

        mainLov = true;
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift)){

            if(mainLov){
                mainKor = true;
                lovis.GetComponent<PlayerMovement>().enabled = false;
                lovis.GetComponent<Checkpoint>().enabled = false;
                lovis.GetComponentInChildren<Health>().enabled = false;
                canvaslovis.SetActive(false);
                lovisA.GetComponent<AnimasiKarakter>().enabled = false;
                korvak.GetComponent<PlayerMovement>().enabled = true;
                korvak.GetComponent<Checkpoint>().enabled = true;
                korvak.GetComponentInChildren<Health>().enabled = true;
                canvaskorvak.SetActive(true);
                korvakA.GetComponent<AnimasiK>().enabled = true;
                mainLov = false;
            }else if(mainKor){
                mainLov = true;
                lovis.GetComponent<PlayerMovement>().enabled = true;
                lovis.GetComponent<Checkpoint>().enabled = true;
                lovis.GetComponentInChildren<Health>().enabled = true;
                canvaslovis.SetActive(true);
                lovisA.GetComponent<AnimasiKarakter>().enabled = true;
                korvak.GetComponent<PlayerMovement>().enabled = false;
                korvak.GetComponent<Checkpoint>().enabled = false;
                korvak.GetComponentInChildren<Health>().enabled = false;
                canvaskorvak.SetActive(false);
                korvakA.GetComponent<AnimasiK>().enabled = false;
                mainKor = false;
            }
        }
    }
}
