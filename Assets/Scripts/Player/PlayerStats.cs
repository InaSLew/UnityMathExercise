using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private Health health;

    private void Update()
    {
        health.Print();
    }
}
