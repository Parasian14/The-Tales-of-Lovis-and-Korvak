using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoinnya : MonoBehaviour
{
    public Animator anim;
    private bool ya;
    [SerializeField]private Checkpoint cp;

    private void Start() {
        anim = GetComponent<Animator>();
    }

    private void Update() {
        if(cp.dapat){
            anim.SetTrigger("Didapat");
        }        
    }
}
