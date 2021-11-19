using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private ReportMousePosition reportMousePosition;
    private Vector3 mouseClickPosition;
    private void Awake()
    {
        reportMousePosition = FindObjectOfType<TAGMainCamera>().gameObject.GetComponent<ReportMousePosition>();
    }

    private void FixedUpdate()
    {
        Debug.Log("am from PlayerMovement.mouseClickPosition: " + reportMousePosition.hitPosition);
        var targetPosition = reportMousePosition.hitPosition;
        // Todo
        // Rotate
        var yAngle = Vector3.Angle(transform.position, targetPosition);
        transform.Rotate(0, yAngle, 0);

        // Move to hit position
    }
}
