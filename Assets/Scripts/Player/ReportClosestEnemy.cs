using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TMPro;
using UnityEngine;

public class ReportClosestEnemy : MonoBehaviour
{
    private List<GameObject> enemies;
    private GameObject closestToPlayer;
    [SerializeField] private TMP_Text closestEnemy;
    
    private void Awake()
    {
        enemies = FindObjectsOfType<TAGEnemy>().Select(x => x.gameObject).ToList();
    }

    private void Update()
    {
        var playerPosition = transform.position;
        var result = enemies.Aggregate(enemies[0], (closest, next) => Vector3.Distance(playerPosition, next.transform.position) < Vector3.Distance(playerPosition, closest.transform.position) ? next : closest);
        Debug.Log("Closest enemy: " + closestEnemy);
        closestToPlayer = result;
    }

    private void LateUpdate()
    {
        closestEnemy.text = Vector3.Distance(transform.position, closestToPlayer.transform.position).ToString(CultureInfo.CurrentCulture);
    }
}
