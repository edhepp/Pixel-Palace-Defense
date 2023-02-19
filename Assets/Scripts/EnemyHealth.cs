using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitpoints = 5;
    [Tooltip("Adds amount to maxHitpoints when enemy dies.")]
    [SerializeField] int difficultyRamp = 1;

    int currentHitPoints = 0;

    Enemy enemy;

    void OnEnable()
    {
        currentHitPoints = maxHitpoints;
    }

    private void Start()
    {
        enemy = GetComponent<Enemy>();
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
            gameObject.SetActive(false);
            enemy.RewardGold();
            maxHitpoints += difficultyRamp;
        }
    }
}
