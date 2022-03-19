using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimasiK : MonoBehaviour
{
   private Animator anim;
    private float jalan;
    private float kecepatan = 5f;
    Transform t;
    [SerializeField]private PlayerMovementK player;

    public bool diBawah;
    public Transform cekBawah;
    public float cekKejauhan;
    public LayerMask bawahnya;


    void Awake()
    {
        anim = GetComponent<Animator>();
        t = transform;
    }

    // Update is called once per frame
    void Update()
    {
        jalan = Input.GetAxis("Horizontal");
        // animasi
        if(Mathf.Abs(jalan * kecepatan) > 0){
            anim.SetBool("Jalan", true);
        }else{
            anim.SetBool("Jalan", false);
        }

        

        diBawah = Physics2D.OverlapCircle(cekBawah.position, cekKejauhan, bawahnya);
        if(player.diTanah || diBawah){
            anim.SetBool("Jump", false);
            anim.SetBool("Jatuh", false);
        }else if(Input.GetKeyDown(KeyCode.Space) && diBawah){
            anim.SetTrigger("Lompat");
        }else if(player.diTanah == false && Input.GetKeyDown(KeyCode.Space) == false){
            anim.SetBool("Jatuh", true);
        }else{
            anim.SetBool("Jump", true);
        }
        
    }
}
