using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.tag == "Selanjutnya"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
