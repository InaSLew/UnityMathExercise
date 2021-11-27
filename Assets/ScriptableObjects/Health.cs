using UnityEngine;

[CreateAssetMenu(fileName = "Health", menuName = "Character/Health")]
public class Health : ScriptableObject
{
    /// <summary>
    /// This ScriptableObject is used for storing character health data and its calculation logic;
    /// any health calculation modifiers should be here🤔
    /// </summary>
    /// 
    [SerializeField] private float maxHealth;
    [SerializeField] private float currentHealth;
    public float CurrentHealth => currentHealth;
    public float MaxHealth => maxHealth;

    public void Print() => Debug.Log("Current health: " + CurrentHealth);
}
