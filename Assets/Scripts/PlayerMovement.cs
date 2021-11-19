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
        reportMousePosition = GameObject.FindObjectOfType<TAGMainCamera>().gameObject.GetComponent<ReportMousePosition>();
    }

    private void FixedUpdate()
    {
        // to be implemented!
    }
}
