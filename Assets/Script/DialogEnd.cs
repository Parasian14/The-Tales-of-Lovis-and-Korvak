using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogEnd : MonoBehaviour
{
    public TextMeshProUGUI dialogtext;
    public string[] kata;
    private int index = 0;
    public float kecepatanT;
    public GameObject satu;
    public GameObject dua;
    public GameObject tiga;

    // Start is called before the first frame update
    void Start()
    {
        Selanjutnya();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Selanjutnya();
        }        
    }

    void Selanjutnya(){
        if(index <= kata.Length - 1){
            dialogtext.text = "";
            StartCoroutine(Write());
        }else{
            satu.SetActive(true);
            dua.SetActive(true);
            tiga.SetActive(false);
        }
    }

    IEnumerator Write(){
        foreach (char Character in kata[index].ToCharArray())
        {
            dialogtext.text += Character;
            yield return new WaitForSeconds(kecepatanT);
        }
        index++;
    }
}
