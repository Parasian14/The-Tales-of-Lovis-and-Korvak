using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Health darah;
    private Vector3 lokasi;
    private Vector3 lokasi2;
    public bool respawn;
    public bool respawn2;
    public bool dapat;
    // Start is called before the first frame update
    void Start()
    {
        lokasi = transform.position;
    }

    public void OnTriggerEnter2D(Collider2D collision){
        
        if(collision.tag == "Checkpoint"){
            lokasi = transform.position;
            dapat = true;
        }else if(collision.tag == "CheckpointS"){
            lokasi2 = transform.position;
        }
    }

    private void Update() {
        if(darah.dead){
            transform.position = lokasi;
            respawn = true;
        }else if(darah.kenaDuri){
            transform.position = lokasi2;
            respawn2 = true;
        }else{
            respawn = false;
            respawn2 = false;
        }
    }
}
