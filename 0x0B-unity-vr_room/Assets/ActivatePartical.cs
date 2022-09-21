using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ControllerManager : MonoBehaviour
{
    private string _controllerName;
    private Animator _animator;
    private float triggerHandAnimation;
    private float _value;
    private GameObject _petrolItem;
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