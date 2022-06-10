using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController Player;
    public float speed = 6f;
    float gravity = -9.8f * 2;
    Vector3 gravityVector = Vector3.zero;
    public float jump = 3f;
    bool isGrounded = true;
    void FixedUpdate()
    {
        isGrounded = Player.isGrounded;
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 direction = transform.right * x + transform.forward * z;

        Player.Move(speed * Time.deltaTime * direction);

        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            gravityVector.y = Mathf.Sqrt(jump * -3.0f * gravity);
        }
        gravityVector.y += gravity * Time.deltaTime;
        Player.Move(gravityVector * Time.deltaTime);
        if (Player.isGrounded == true && gravityVector.y < 0)
            gravityVector.y = -1f;

        if (Player.transform.position.y < -20)
            transform.position = new Vector3(0, 20, 0);

    }

}