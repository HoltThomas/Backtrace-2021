using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private bool isGrounded;
    private Rigidbody rbPlayer;
    private float jumpForce = 500.0f;

    private void Start()
    {
        rbPlayer = this.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        RaycastHit hit;

        Debug.DrawRay(transform.position, transform.up * -1.0f, Color.red);

        var hasFloorRayDetectedSomething = Physics.Raycast(transform.position, transform.TransformDirection(transform.up * -1.0f), out hit, 2.0f);


        if (hasFloorRayDetectedSomething)
        {
            if (hit.collider.tag == "Ground")
            {
                isGrounded = true;
            }
        }
        else
        {
            isGrounded = false;
        }

        if (isGrounded)
        {
            var doesPlayerWantToJump = Input.GetKeyDown(KeyCode.Space);

            if (doesPlayerWantToJump)
            {
                rbPlayer.AddForce(transform.up * jumpForce);
            }
        }
    }
}
