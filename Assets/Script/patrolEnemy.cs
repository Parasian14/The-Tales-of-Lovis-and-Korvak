using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrolEnemy : MonoBehaviour
{
    private bool kembali;
    private bool patroli;
    public bool ganti;
    public Rigidbody2D rb;
    public float kecepatan;

    public Transform terbang;
    public LayerMask posisi;
    public Collider2D col;

    void Start()
    {
        patroli = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(patroli){
            Patrol();
        }
    }

    private void FixedUpdate() {
        if(patroli){
            kembali = !Physics2D.OverlapCircle(terbang.position, 0.3f, posisi);
        }
    }

    public void Patrol(){
        if(kembali){
            Balik();
        }
        ganti = false;
        rb.velocity = new Vector2(kecepatan * Time.fixedDeltaTime, rb.velocity.y);
    }

    public void Balik(){
        patroli = false;
        ganti = true;
        transform.localScale = new Vector2( transform.localScale.x * -1,transform.localScale.y);
        kecepatan *= -1;
        patroli = true;
    }
}
