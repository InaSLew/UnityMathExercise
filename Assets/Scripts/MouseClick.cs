using System;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    private Camera cam;
    [SerializeField] private Vector3 mousePoint;

    private void Awake()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse position: " + mousePoint);
        }
    }

    private void OnGUI()
    {
        Event currentEvent = Event.current;
        var mousePos = new Vector2
        {
            x = currentEvent.mousePosition.x,
            y = cam.pixelHeight - currentEvent.mousePosition.y
        };

        mousePoint = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));
        // var point = cam.ScreenToViewportPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));
    }
}
