using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private ReportMousePosition reportMousePosition;
    [SerializeField] private float angularSpeed;
    private void Awake()
    {
        reportMousePosition = FindObjectOfType<TAGMainCamera>().gameObject.GetComponent<ReportMousePosition>();
    }

    // Vector3.MoveTowards to walk from a point to a point with a maxSpeed.
    private void FixedUpdate()
    {

        if (transform.rotation == reportMousePosition.targetRotation)
        {
            Debug.Log("Turning finished");
        }
        else
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, reportMousePosition.targetRotation,
                angularSpeed * Time.deltaTime);
        }

        // Move to hit position
    }
}
