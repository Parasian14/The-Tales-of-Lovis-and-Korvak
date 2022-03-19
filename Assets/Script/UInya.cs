using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UInya : MonoBehaviour
{
    [SerializeField] private GameObject gb;
    
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)){
            gb.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
