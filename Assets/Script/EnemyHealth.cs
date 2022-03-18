using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float maxHealth = 2;
    float currentHealth;

    // Update is called once per frame
    private void Start()
    {
        currentHealth = maxHealth;
    }
}
