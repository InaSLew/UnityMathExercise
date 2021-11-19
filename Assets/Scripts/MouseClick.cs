using UnityEngine;

public class MouseClick : MonoBehaviour
{
    private Camera cam;

    private void Awake()
    {
        cam = Camera.main;
    }

    private void OnGUI()
    {
        Event currentEvent = Event.current;
        var mousePos = new Vector2
        {
            x = currentEvent.mousePosition.x,
            y = cam.pixelHeight - currentEvent.mousePosition.y
        };

        var point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));
        
        Debug.Log("Mouse position: " + point);
    }
}
