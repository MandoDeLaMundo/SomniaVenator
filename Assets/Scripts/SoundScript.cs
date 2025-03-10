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
            Debug.Log("Walking 1 key");
        }
        else if (context.performed && mWalkSource.isPlaying)
        {
            Debug.Log("Walking 2 Keys");
        }
        else
        {
            mWalkSource.Stop();
            Debug.Log("Audio Stops.");
        }
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && !mJumpSource.isPlaying)
        {
            mJumpSource.Play();
            Debug.Log("Jumping");
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
