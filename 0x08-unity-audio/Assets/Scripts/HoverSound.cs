using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverSound : MonoBehaviour
{
    public AudioClip hoverSound;
    public AudioClip clickSound;
    public AudioSource mySound;



    public void PlayHoverSound()
    {
        mySound.PlayOneShot(hoverSound);
    }

    public void PlayClikSound()
    {
        mySound.PlayOneShot(clickSound);
    }
}
