using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 10;
    private CastelHP castleHealth;

    void Start()
    {
        castleHealth = FindObjectOfType<CastelHP>(); // Находим замок в сцене
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Castle"))
        {
            castleHealth.TakeDamage(damage);
            Destroy(gameObject);

        }
    }
}
