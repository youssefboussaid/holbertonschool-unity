using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class FootSteps : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip clip;
    public AudioClip hit;

 

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Step()
    {
        audioSource.PlayOneShot(clip);
    }

    private void HitGround()
    {
        audioSource.PlayOneShot(hit);
    }

   
}
