using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ReportClosestEnemy : MonoBehaviour
{
    private List<GameObject> enemies;
    [SerializeField] private GameObject closestToPlayer;
    
    private void Awake()
    {
        enemies = FindObjectsOfType<TAGEnemy>().Select(x => x.gameObject).ToList();
    }

    private void Update()
    {
        var playerPosition = transform.position;
        var closestEnemy = enemies.Aggregate(enemies[0], (closest, next) => Vector3.Distance(playerPosition, next.transform.position) < Vector3.Distance(playerPosition, closest.transform.position) ? next : closest);
        Debug.Log("Closest enemy: " + closestEnemy);
    }
}
