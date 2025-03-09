using UnityEngine;

public class DisapearingPlatform : MonoBehaviour
{
    public bool isTriggered;
    public bool isRegening;
    public float activateTimer = 0;
    public float deactivateTimer = 0;
    public GameObject platform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        isTriggered = false;
        platform = transform.GetChild(0).gameObject;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isTriggered == true)
        {
            activateTimer -= Time.deltaTime;
            if (activateTimer <= 0)
            {
                platform.SetActive(false);
                deactivateTimer = 3.0f;
                isRegening = true;
                isTriggered = false;
            }
        }
        if (isRegening == true)
        {
            deactivateTimer -= Time.deltaTime;
            if (deactivateTimer <= 0)
            {
                platform.SetActive(true);
                isRegening = false;
            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            activateTimer = 2.0f;
            isTriggered = true;
        }
    }
}
