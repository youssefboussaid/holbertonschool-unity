using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    private Vector3 offset;
    public bool isInverted;
    public float turnSpeed = 5f;

    void Start()
    {
        offset = transform.position - player.position;
    }
    void LateUpdate()
    {
        float view = Input.GetAxis("Mouse X");


        if (isInverted)
            view = -view;


        offset = Quaternion.AngleAxis(view * turnSpeed, Vector3.up) * offset;

        Vector3 desiredPosition = player.position + offset;
        transform.position = desiredPosition;
        transform.LookAt(player.position);
        player.Rotate(Input.GetAxis("Mouse X") * turnSpeed * Vector3.up);
        


    }


}