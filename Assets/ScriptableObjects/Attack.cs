using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Attack", menuName = "Character/Attack")]
public class Attack : ScriptableObject
{
    /// <summary>
    /// This ScriptableObject holds data and calculation logic related to attack.
    /// Modifiers pertaining to calculating the final attack damage should be here.
    /// </summary>
    /// 
    [SerializeField] private float power;
    public float Power { get; private set; }

    public void Print() => Debug.Log("Attack power " + Power);
}
