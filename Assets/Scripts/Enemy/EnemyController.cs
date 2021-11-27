using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Health health;

    public void TakeDamage()
    {
        Debug.Log("Enemy takes damage from player!");
    }
}
