using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupCamAtStart : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
