using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowText : MonoBehaviour
{
    public Canvas Text;


    public void Show()
    {
        Text.gameObject.SetActive(true);
    }
    public void UnShow()
    {
        Text.gameObject.SetActive(false);
    }
}
