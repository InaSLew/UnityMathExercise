using System;
using UnityEngine;

public class ReportMousePosition : MonoBehaviour
{
    private Camera cam;
    private RaycastHit hit;
    private GameObject player;
    [SerializeField] public Quaternion targetRotation = Quaternion.identity;
    
    private void Awake()
    {
        cam = Camera.main;
        player = FindObjectOfType<TAGPlayer>().gameObject;
    }

    // Quaternion.RotateTowards to Interpolate between two rotations.
    // Quaternion.FromToRotation to get the Angle from a point to a point.
    // Vector3.MoveTowards to walk from a point to a point with a maxSpeed. (If you want to do it with RigidBody / Acceleration, it's even better)
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                var playerTransform = player.transform;
                var hitPosition = new Vector3(hit.point.x , playerTransform.position.y, hit.point.z);
                Debug.DrawLine(ray.origin, hitPosition, Color.red);
                targetRotation =
                    Quaternion.FromToRotation(playerTransform.forward, hitPosition - playerTransform.position);

                // no smooth transitioning
                // playerTransform.rotation = 
                //     Quaternion.FromToRotation(playerTransform.forward, hitPosition - playerTransform.position);

                // var targetRotation = Quaternion.FromToRotation(playerTransform.forward, hitPosition - playerTransform.position);
                // playerTransform.rotation = Quaternion.RotateTowards(playerTransform.rotation, targetRotation, angularSpeed * Time.deltaTime);
            }
        }
    }
}
