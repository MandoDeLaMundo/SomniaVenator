using TMPro;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public bool starDestroyed = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            starDestroyed = true;
            Destroy(gameObject);
            Debug.Log("Star has been destroyed");
            starDestroyed = false;
        }
    }
}
