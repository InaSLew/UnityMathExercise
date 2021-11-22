using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private ReportMousePosition reportMousePosition;
    [SerializeField] private float angularSpeed;
    private void Awake()
    {
        reportMousePosition = FindObjectOfType<TAGMainCamera>().gameObject.GetComponent<ReportMousePosition>();
    }

    // Quaternion.RotateTowards to Interpolate between two rotations.
    // Quaternion.FromToRotation to get the Angle from a point to a point.
    // Vector3.MoveTowards to walk from a point to a point with a maxSpeed.
    private void FixedUpdate()
    {
        if (Quaternion.Angle(transform.rotation, reportMousePosition.targetRotation) <= .01f)
        {
            Debug.Log("Turning finished");
        }
        else
        {
            Debug.Log("Turning in progress: " + transform.rotation);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, reportMousePosition.targetRotation,
                angularSpeed * Time.deltaTime);
        }

        // Move to hit position
    }
}
