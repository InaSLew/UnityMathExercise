using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private ReportMousePosition reportMousePosition;
    private Vector3 mouseClickPosition;
    private Vector3 targetPosition;
    [SerializeField] private float speed = .1f;
    private void Awake()
    {
        reportMousePosition = FindObjectOfType<TAGMainCamera>().gameObject.GetComponent<ReportMousePosition>();
    }

    // Quaternion.RotateTowards to Interpolate between two rotations.
    // Quaternion.FromToRotation to get the Angle from a point to a point.
    // Vector3.MoveTowards to walk from a point to a point with a maxSpeed.
    private void FixedUpdate()
    {
        targetPosition = reportMousePosition.hitPosition;
        Debug.Log("am from PlayerMovement.mouseClickPosition: " + targetPosition);
        

        // var yAngle = Vector3.Angle(transform.position, targetPosition);
        // Debug.Log("yAngle: " + yAngle);
        // transform.Rotate(0, yAngle * Time.deltaTime, 0);

        // Move to hit position
    }
}
