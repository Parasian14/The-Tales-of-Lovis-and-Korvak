using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class dialogController : MonoBehaviour
{
    public TextMeshProUGUI dialogtext;
    public string[] kata;
    private int index = 0;
    public float kecepatanT;

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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
