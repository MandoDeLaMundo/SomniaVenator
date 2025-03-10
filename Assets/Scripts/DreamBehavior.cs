using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class DreamBehavior : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Vector3 destination;
    public Vector3[] movePoints;
    public int movePointTracker = 0;
    public float distanceFromDestination;
    public bool canMove = true;
    public GameObject star;
    public AudioSource mCatCloud;

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
        if (distanceFromDestination <= 1.2)
        {
            canMove = true;
            mCatCloud.Pause();
            Debug.Log("Cat Cloud's Moving, Audio should be playing");
        }
    }

    void SetNewDestination()
    {
        if (movePointTracker != 0)
        {
            Instantiate(star, destination, Quaternion.identity);
        }
        destination = movePoints[movePointTracker];
        navMeshAgent.SetDestination(destination);
        movePointTracker++;
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (movePointTracker < 4)
            {
                SetNewDestination();
                canMove = false;
                mCatCloud.Play();
                Debug.Log("CatCloud Stops. No More Sounds.");
            }
            else
            {
                Debug.Log("You Win");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
