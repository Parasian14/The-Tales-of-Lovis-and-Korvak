using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementK : MonoBehaviour
{
    private float jalan;
    private float naik;
    public Rigidbody2D badan { get; private set; }
    Transform t;
    public float tinggiLompat;

    [SerializeField]private float kecepatan;

    public bool diTanah;
    public Transform cekTanah;
    public float cekKejauhan;
    public LayerMask tanahnya;
    private Vector3 kunci;
    [SerializeField]private PlayerInteraction playerIn;

    private float lompat = 1;

    private void Awake(){
        badan = GetComponent<Rigidbody2D>();
        t = transform;
    }

    private void Update(){    
        //berjalan
        jalan = Input.GetAxis("Horizontal");
        badan.velocity = new Vector2(jalan * kecepatan, badan.velocity.y);  

        //balik badan
        if(playerIn.pegang){
            transform.localScale = kunci;
        }else if(jalan > 0.01f){
            transform.localScale = new Vector3(1, 1, 1);
            kunci = transform.localScale;
        }else if(jalan < -0.01f){
            transform.localScale = new Vector3(-1, 1, 1);
            kunci = transform.localScale;
        }  
        
        diTanah = Physics2D.OverlapCircle(cekTanah.position, cekKejauhan, tanahnya);
        //Double Jump
        if(diTanah == true){
            lompat = 1;
        }
        //lompat
        if(Input.GetKeyDown(KeyCode.Space) && lompat > 0){
            badan.velocity = new Vector2(badan.velocity.x, tinggiLompat);
            lompat--;
        }
 
    }
}
