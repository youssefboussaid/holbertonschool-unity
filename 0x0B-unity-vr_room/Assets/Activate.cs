using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Activate : MonoBehaviour
{ 
    public GameObject partical;



    void Update()
    {
        var inputDevices = new List<InputDevice>();
        InputDevices.GetDevices(inputDevices);
        foreach (var device in inputDevices)
        {
            bool primaryValue;

            if (device.TryGetFeatureValue(CommonUsages.primaryButton, out primaryValue) && primaryValue)
            {
                partical.SetActive(true);
            }
        }
    }
}
