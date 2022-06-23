using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void QuitGmae()
        {
            Debug.Log("Exited");
            Application.Quit();
        }
}
