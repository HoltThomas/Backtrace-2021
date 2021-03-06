using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    public bool gamePaused = false;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    [SerializeField] private GameObject player;
    [SerializeField] private Camera playerCam;

    void Update()
    {
        if(!gamePaused)
        {
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");

            player.transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
            playerCam.transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
    }
}
