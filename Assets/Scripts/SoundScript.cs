using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class SoundScript : MonoBehaviour
{
    public AudioSource mWalkSource;
    //public AudioClip footsteps;
    public AudioSource mJumpSource;
    //[SerializeField] private PlayerMovement moveSound;
    public void Move(InputAction.CallbackContext context)
    {
        if (context.performed && !mWalkSource.isPlaying)
        {
            mWalkSource.Play();
        }
        else if (context.performed && mWalkSource.isPlaying)
        {

        }
        else
        {
            mWalkSource.Stop();
        }
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && !mJumpSource.isPlaying)
        {
            mJumpSource.Play();
        }
        else if (context.performed && mJumpSource.isPlaying)
        {

        }
        else
        {
            mJumpSource.Stop();
        }
    }
}
