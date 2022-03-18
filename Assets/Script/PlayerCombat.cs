using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator anim;

    public Transform attackPoint;
    public float rangeAttack = 0.5f;
    public LayerMask enemyLayers;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Attack();
        }
    }

    void  Attack()
    {
        anim.SetTrigger("Serang");
        Collider2D[] hitEnemies =  Physics2D.OverlapCircleAll(attackPoint.position, rangeAttack, enemyLayers);

        foreach (Collider2D enemy in hitEnemies) 
        {
            
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawSphere(attackPoint.position, rangeAttack);
    }
}
