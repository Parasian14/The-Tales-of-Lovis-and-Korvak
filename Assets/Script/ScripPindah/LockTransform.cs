using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockTransform : MonoBehaviour
{
    public ChangePlayer cp;
    public Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if(cp.mainKor && !cp.mainLov){
            rb.transform.position = new Vector2(rb.transform.position.x, rb.transform.position.y);
        }
    }
}
