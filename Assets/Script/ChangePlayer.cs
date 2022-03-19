using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayer : MonoBehaviour
{

    public GameObject lovis;
    public GameObject lovisA;
    public Rigidbody2D rbLovis;
    public GameObject korvak;
    public GameObject korvakA;
    public Rigidbody2D rbKorvak;
    public GameObject canvaslovis;
    public GameObject canvaskorvak;
    public bool mainLov;
    public bool mainKor;

    void Start()
    {
        

        canvaslovis = GameObject.Find("UICanvas");
        canvaskorvak = GameObject.Find("UICanvas 1");
        lovis.GetComponent<PlayerMovement>().enabled = true;
        korvak.GetComponent<PlayerMovementK>().enabled = false;
        korvak.GetComponent<Checkpoint>().enabled = false;
        korvak.GetComponentInChildren<Health>().enabled = false;
        canvaskorvak.SetActive(false);
        korvakA.GetComponent<AnimasiK>().enabled = false;
        rbKorvak.constraints = RigidbodyConstraints2D.FreezePosition | RigidbodyConstraints2D.FreezeRotation;
        mainLov = true;
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift)){

            if(mainLov){
                mainKor = true;
                rbKorvak.constraints = RigidbodyConstraints2D.FreezeRotation | ~RigidbodyConstraints2D.FreezePosition;
                lovis.GetComponent<PlayerMovement>().enabled = false;
                lovis.GetComponent<Checkpoint>().enabled = false;
                lovis.GetComponentInChildren<Health>().enabled = false;
                canvaslovis.SetActive(false);
                lovisA.GetComponent<AnimasiKarakter>().enabled = false;
                lovisA.GetComponent<AnimasiD>().enabled = true;
                korvak.GetComponent<PlayerMovementK>().enabled = true;
                korvak.GetComponent<Checkpoint>().enabled = true;
                korvak.GetComponentInChildren<Health>().enabled = true;
                canvaskorvak.SetActive(true);
                korvakA.GetComponent<AnimasiK>().enabled = true;
                korvakA.GetComponent<AnimasiE>().enabled = false;
                rbLovis.constraints = RigidbodyConstraints2D.FreezePosition | RigidbodyConstraints2D.FreezeRotation;
                mainLov = false;
            }else if(mainKor){
                mainLov = true;
                rbLovis.constraints = RigidbodyConstraints2D.FreezeRotation | ~RigidbodyConstraints2D.FreezePosition;
                lovis.GetComponent<PlayerMovement>().enabled = true;
                lovis.GetComponent<Checkpoint>().enabled = true;
                lovis.GetComponentInChildren<Health>().enabled = true;
                lovisA.GetComponent<AnimasiD>().enabled = false;
                canvaslovis.SetActive(true);
                lovisA.GetComponent<AnimasiKarakter>().enabled = true;
                korvak.GetComponent<PlayerMovementK>().enabled = false;
                korvak.GetComponent<Checkpoint>().enabled = false;
                korvak.GetComponentInChildren<Health>().enabled = false;
                korvakA.GetComponent<AnimasiE>().enabled = true;
                canvaskorvak.SetActive(false);
                korvakA.GetComponent<AnimasiK>().enabled = false;
                rbKorvak.constraints = RigidbodyConstraints2D.FreezePosition | RigidbodyConstraints2D.FreezeRotation;
                mainKor = false;
            }
        }
    }
}
