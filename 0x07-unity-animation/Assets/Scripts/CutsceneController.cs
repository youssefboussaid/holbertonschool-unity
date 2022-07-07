using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneController : MonoBehaviour
{

    private GameObject player;
    public GameObject camera;
    public GameObject timercanvas;
    public Animator anim;

    public void Start()
    {
        player = GameObject.Find("Player");
    }

    public void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            timercanvas.SetActive(true);
            camera.SetActive(true);
            player.GetComponent<PlayerController>().enabled = true;
            this.gameObject.SetActive(false);
        }
            
    }
}
    
