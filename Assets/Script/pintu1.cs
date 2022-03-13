using UnityEngine;

public class pintu1 : MonoBehaviour
{
    //script untuk pintu
    [SerializeField] private Transform pos1, pos2, posAwal;
    [SerializeField] private float kecepatanBuka;
    Vector3 nextPos;
    

    private void Start()
    {
        nextPos = posAwal.position;
    }
    public void BukaPintu()
    {
        //jika dipanggil, pintu akan bergerak ke atas sedikit
        if (transform.position != pos2.position)
            nextPos = pos2.position;
        transform.position = Vector3.MoveTowards(transform.position, nextPos, kecepatanBuka * Time.deltaTime);
    }

    private void Update()
    {
        //jika tombol diinjak, boolean preesed akan menjadi true dan method pintu dipanggil berkali-kali.
        if (GameObject.Find("tombol1").GetComponent<tombol1>().pressed == true){
            BukaPintu();
            gameObject.SetActive(false);
        }
            
    }

    private void OnDrawGizmos()
    {
        //garis kearah mana pintu bergerak
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}
