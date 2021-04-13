
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;
    public Rigidbody playerRB;

    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizontal != 0)
        {
            transform.Rotate(0, turnSpeed * Time.deltaTime * horizontal, 0);
        }

        if (vertical != 0)
        {
            Vector3 targetMovement = transform.forward * moveSpeed * Time.deltaTime * vertical;
            playerRB.MovePosition(playerRB.position + targetMovement);
        }
    }

}
