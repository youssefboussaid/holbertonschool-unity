using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinTrigger : MonoBehaviour
{

    public GameObject Player;

    public TextMeshProUGUI win_text;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player.gameObject.GetComponent<Timer>().enabled = false;

            win_text.color = Color.green;
            win_text.fontSize = 60;
        }
    }
}
