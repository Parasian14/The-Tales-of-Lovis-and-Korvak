using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2 : MonoBehaviour
{
    public ChangePlayer cp;
    public Transform lovis;
    public Transform korvak;
    public Vector3 offset;
    [Range(1,10)]
    public float halus;

    public void FixedUpdate(){
        if(cp.mainLov && !cp.mainKor){
            FollowLovis();
        }else if(!cp.mainLov && cp.mainKor){
            FollowKorvak();
        }
    }

    public void FollowLovis(){
        Vector3 posisiPlayer = lovis.position + offset;
        Vector3 lembut = Vector3.Lerp(transform.position, posisiPlayer, halus * Time.fixedDeltaTime);
        transform.position = lembut;
    }

    public void FollowKorvak(){
        Vector3 posisiPlayer = korvak.position + offset;
        Vector3 lembut = Vector3.Lerp(transform.position, posisiPlayer, halus * Time.fixedDeltaTime);
        transform.position = lembut;
    }
}
