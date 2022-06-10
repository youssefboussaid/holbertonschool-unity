using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI text_time;
    float second;
    int minite;
    // Update is called once per frame
    void Update()
    {
        second += Time.deltaTime;
        text_time.text = string.Format("{0}{1:00.00}",minite, second);

        if (second >= 60)
        {
            minite ++;
            second = 0;
        }
    }
}
