using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimasiD : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Berjalan", false);
        anim.SetBool("Jump", false);
    }
}
