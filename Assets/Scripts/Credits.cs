using UnityEngine;

public class Credits : MonoBehaviour
{
    public GameObject creditsUI;
    public GameObject menuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            creditsUI.SetActive(false);
            menuUI.SetActive(true);
        }
    }
}
