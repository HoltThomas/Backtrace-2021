using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private float playerSpeed = 10.0f;

    private void Update()
    {
        CheckForMovementInput();
    }

    private void CheckForMovementInput()
    {
        var isPlayerPressingForwards = Input.GetKey(KeyCode.W);
        var isPlayerPressingBackwards = Input.GetKey(KeyCode.S);
        var isPlayerPressingLeft = Input.GetKey(KeyCode.A);
        var isPlayerPressingRight = Input.GetKey(KeyCode.D);

        if (isPlayerPressingForwards)
        {
            player.transform.position += transform.forward * playerSpeed * Time.deltaTime;
        }
        if (isPlayerPressingBackwards)
        {
            player.transform.position -= transform.forward * playerSpeed * Time.deltaTime;
        }
        if (isPlayerPressingLeft)
        {
            player.transform.position -= transform.right * playerSpeed * Time.deltaTime;
        }
        if (isPlayerPressingRight)
        {
            player.transform.position += transform.right * playerSpeed * Time.deltaTime;
        }
    }
}
