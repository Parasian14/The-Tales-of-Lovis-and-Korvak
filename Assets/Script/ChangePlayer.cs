using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayer : MonoBehaviour
{

    public GameObject lovis;
    public GameObject lovisA;
    public GameObject korvak;
    public GameObject korvakA;
    public bool mainLov;
    public bool mainKor;

    void Start()
    {
        lovis.GetComponent<PlayerMovement>().enabled = true;
        korvak.GetComponent<PlayerMovement>().enabled = false;
        korvakA.GetComponent<AnimasiK>().enabled = false;
        mainLov = true;
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift)){
            if(mainLov){
                mainKor = true;
                lovis.GetComponent<PlayerMovement>().enabled = false;
                lovisA.GetComponent<AnimasiKarakter>().enabled = false;
                korvak.GetComponent<PlayerMovement>().enabled = true;
                korvakA.GetComponent<AnimasiK>().enabled = true;
                mainLov = false;
            }else if(mainKor){
                mainLov = true;
                lovis.GetComponent<PlayerMovement>().enabled = true;
                lovisA.GetComponent<AnimasiKarakter>().enabled = true;
                korvak.GetComponent<PlayerMovement>().enabled = false;
                korvakA.GetComponent<AnimasiK>().enabled = false;
                mainKor = false;
            }
        }
    }
}
