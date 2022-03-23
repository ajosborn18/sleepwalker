using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Health.health -= 1; 
        }
        if(other.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            //_animator.SetTrigger("Die");
            Destroy(gameObject);
        }
        
    }
}
