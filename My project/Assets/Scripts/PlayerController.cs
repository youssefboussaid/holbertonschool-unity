using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController _controller;


    

    [SerializeField]
    private float _speed = 5f;

    [SerializeField]
    private float _jump = 5f;

    [SerializeField]
    private float _gravity = 10f;

    private float _directionY;

    public Transform spawnPoint;//Add empty gameobject as spawnPoint
    public float minHeightForDeath;
    public GameObject player; //Add your player






    private void Start()
    {
        _controller = GetComponent<CharacterController>();

    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);

        if (_controller.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                _directionY = _jump;
            }
        }
        _directionY -= _gravity * Time.deltaTime;

        direction.y = _directionY;

        _controller.Move(direction * Time.deltaTime * _speed);

        if (player.transform.position.y < minHeightForDeath)
        {
            print("hello");
            player.transform.position = spawnPoint.position;
        }
                
    }

}

