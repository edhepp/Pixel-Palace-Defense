using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitpoints = 5;
    int currentHitPoints = 0;


    void Start()
    {
        currentHitPoints = maxHitpoints;
    }

    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    void ProcessHit()
    {
        currentHitPoints--;
        if (currentHitPoints < 1)
        {
            Destroy(this.gameObject);
        }
    }
}
