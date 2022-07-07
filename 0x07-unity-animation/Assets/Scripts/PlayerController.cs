using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController Player;
    public Transform cam;
    public float speed = 6f;
    float gravity = -9.8f * 2;
    Vector3 gravityVector = Vector3.zero;
    public float jump = 3f;
    bool isGrounded = true;
    private Animator animator;

    Vector3 moveDirection;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }


    void FixedUpdate()
    {
        float x = 0;
        float z = 0;
        isGrounded = Player.isGrounded;
        x += Input.GetAxis("Horizontal");
        z += Input.GetAxis("Vertical");
        Vector3 sideMove = Quaternion.Euler(0f, cam.eulerAngles.y, 0f) * Vector3.right;
        Vector3 forwardMove = Quaternion.Euler(0f, cam.eulerAngles.y, 0f) * Vector3.forward;

        moveDirection = x * sideMove + forwardMove * z;
        Player.Move(moveDirection * speed * Time.deltaTime);

        Quaternion PlayerLookDirection = Quaternion.LookRotation(moveDirection);


        


        if (moveDirection.magnitude > 0f)
        {
            Player.transform.rotation = Quaternion.Slerp(Player.transform.rotation, PlayerLookDirection, speed * Time.deltaTime);
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            gravityVector.y = Mathf.Sqrt(jump * -3.0f * gravity);
            animator.SetTrigger("jump");
        }
        gravityVector.y += gravity * Time.deltaTime;
        Player.Move(gravityVector * Time.deltaTime);
        if (Player.isGrounded == true && gravityVector.y < 0)
            gravityVector.y = -1f;

        if (Player.transform.position.y < -40)
            transform.position = new Vector3(0, 20, 0);

        if (Player.transform.position.y < -5)
        {
            animator.SetTrigger("fall");
        }

        if (Player.isGrounded)
        {
            animator.SetBool("isCrushed", false);
            animator.SetBool("isUp", false);
        }


    }

}