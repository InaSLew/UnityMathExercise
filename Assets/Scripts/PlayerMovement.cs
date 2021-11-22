using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private ReportMousePosition reportMousePosition;
    [SerializeField] private float angularSpeed;
    [SerializeField] private float maxSpeed;
    
    private void Awake()
    {
        reportMousePosition = FindObjectOfType<TAGMainCamera>().gameObject.GetComponent<ReportMousePosition>();
    }

    private void FixedUpdate()
    {

        if (transform.rotation == reportMousePosition.targetRotation)
        {
            transform.position = Vector3.MoveTowards(transform.position, reportMousePosition.targetPosition, maxSpeed * Time.deltaTime);
        }
        else
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, reportMousePosition.targetRotation,
                angularSpeed * Time.deltaTime);
        }
    }
}
