using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Vector3 startPoint;
    public Vector3 endPoint;
    public Vector3 destination;
    public float moveSpeed;
    public float distanceFromDestination;
    void Start()
    {
        destination = endPoint;
        moveSpeed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, moveSpeed * Time.deltaTime);
        distanceFromDestination = (destination - transform.position).magnitude;
        if (distanceFromDestination <= 1)
        {
            if (destination == endPoint)
            {
                destination = startPoint;
            }
            else
            {
                destination = endPoint;
            }
        }
    }
}
