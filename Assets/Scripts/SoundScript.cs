using UnityEngine;
using System;

public class SoundScript : MonoBehaviour
{
    public AudioSource soundSource;
    public AudioClip footsteps;

    [SerializeField] private PlayerMovement moveSound;

}
