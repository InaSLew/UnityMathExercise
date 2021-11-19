using System;
using UnityEngine;

public class ReportMousePosition : MonoBehaviour
{
    private Camera cam;
    private RaycastHit hit;
    [SerializeField] public Vector3 hitPosition;
    private GameObject player;
    
    private void Awake()
    {
        cam = Camera.main;
        player = FindObjectOfType<TAGPlayer>().gameObject;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                hitPosition = hit.point;
                Debug.DrawLine(ray.origin, hitPosition, Color.red);

                var playerTransform = player.transform;
                playerTransform.rotation =
                    Quaternion.FromToRotation(playerTransform.forward, hitPosition - playerTransform.position);
            }
        }
    }
}
