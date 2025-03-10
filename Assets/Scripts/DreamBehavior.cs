using UnityEngine;
using UnityEngine.AI;

public class DreamBehavior : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Vector3 destination;
    public Vector3[] movePoints;
    int movePointTracker = 0;
    public float distanceFromDestination;
    public bool canMove = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        destination = movePoints[movePointTracker];
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distanceFromDestination = (transform.position - destination).magnitude;
        if (distanceFromDestination <= 1)
        {
            canMove = true;
        }
    }

    void SetNewDestination()
    {
        movePointTracker++;
        destination = movePoints[movePointTracker];
        navMeshAgent.SetDestination(destination);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SetNewDestination();
            canMove = false;
        }
    }
}
