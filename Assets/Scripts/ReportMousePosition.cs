using System;
using UnityEngine;

public class ReportMousePosition : MonoBehaviour
{
    private Camera cam;
    private RaycastHit hit;
    private GameObject player;
    [SerializeField] public Quaternion targetRotation;
    [SerializeField] public Vector3 targetPosition;
    
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
                var playerTransform = player.transform;
                targetPosition = new Vector3(hit.point.x , playerTransform.position.y, hit.point.z);
                Debug.DrawLine(ray.origin, targetPosition, Color.red);
                targetRotation =
                    Quaternion.FromToRotation(Vector3.forward, (targetPosition - playerTransform.position).normalized);
            }
        }
    }
}
