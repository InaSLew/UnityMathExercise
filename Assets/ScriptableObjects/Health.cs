using UnityEngine;

[CreateAssetMenu(fileName = "Health", menuName = "Character/Health")]
public class Health : ScriptableObject
{
    [SerializeField] private float maxHealth;
    [SerializeField] private float currentHealth;
    public float CurrentHealth => currentHealth;
    public float MaxHealth => maxHealth;

    public void Print() => Debug.Log("Current health: " + CurrentHealth);
}
