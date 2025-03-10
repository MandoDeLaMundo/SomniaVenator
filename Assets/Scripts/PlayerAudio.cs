using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAudio : MonoBehaviour
{

    public AK.Wwise.Event mMoveEvent;
    public AK.Wwise.Event mStopEvent;
    public AK.Wwise.Event mJumpEvent;
    public AK.Wwise.Event mJumpStop;
    public bool mIsWalking = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(InputAction.CallbackContext context)
    {
        if (context.performed && mIsWalking == false)
        {
            mMoveEvent.Post(this.gameObject);
            mIsWalking = true;
            Debug.Log("Walking with 1 sound");
        }
        else if(context.performed && mIsWalking == true)
        {
            Debug.Log("Walking Multiple Inputs");
        }
        else
        {
            mStopEvent.Post(this.gameObject);
            mIsWalking = false;
            Debug.Log("Stop Audio");
        }
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            mJumpEvent.Post(this.gameObject);
        }
        else
        {
            mJumpStop.Post(this.gameObject);
        }

        //AkSoundEngine.PostEvent("Play_Jump", this.gameObject);
    }
}
