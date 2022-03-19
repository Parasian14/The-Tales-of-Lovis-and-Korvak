using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimasiE : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Jalan", false);
        anim.SetBool("Jump", false);
    }
}

