using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour {
    public float speed = 3.0f;
    float moveX = 0;
    float moveZ = 0;

    CharacterController controller;

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {


        Vector3 forward = Camera.main.transform.TransformDirection(Vector3.forward);
        Vector3 right = Camera.main.transform.TransformDirection(Vector3.right);

        if (Input.GetKey("left shift"))
        {
            speed = 6.0f;
        }
        else
        {
            speed = 3.0f;
        }
       
        moveX = Input.GetAxis("Horizontal") * speed;
        moveZ = Input.GetAxis("Vertical") * speed;

        Vector3 direction = moveX * right + moveZ * forward;

        controller.SimpleMove(direction);
    }
}
