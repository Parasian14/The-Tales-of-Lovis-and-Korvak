using UnityEngine;

public class tombol1 : MonoBehaviour
    //Script yang berjalan jika tombol di injak
{
    public Renderer r;
    public bool pressed = false;
    private Animator anim;

    private void Awake()
    {
        r = GetComponent<Renderer>();
        anim = GetComponent<Animator>();
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            pressed = true;
            anim.SetTrigger("pencet"); 
        }
    }

}
