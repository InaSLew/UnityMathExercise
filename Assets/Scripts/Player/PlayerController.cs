using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] private Attack attack;
    [SerializeField] private GameEvent onPlayerAttack;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            onPlayerAttack.Raise();
        }
    }
}
