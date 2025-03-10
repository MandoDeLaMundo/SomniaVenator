using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAudio : MonoBehaviour
{

    public AudioSource mSteps;
    public AudioSource mJump;
    public bool mIsWalking = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mJump.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Move(InputAction.CallbackContext context)
    {
        if (context.performed && mIsWalking == false)
        {
            mSteps.Play();
            mIsWalking = true;
            Debug.Log("Walking with 1 sound");
        }
        else if (context.performed && mIsWalking == true)
        {
            Debug.Log("Walking Multiple Inputs");
        }
        else
        {
            //mSteps.Stop();
            mIsWalking = false;
            Debug.Log("Stop Audio");
        }
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            mJump.Play();
            Debug.Log("Jump played");
        }
        else
        {
            mJump.Stop();
        }
    }
}

