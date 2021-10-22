using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private RotateCamera sRotateCamera;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            switch(pauseMenu.active)
            {
                case true:
                    pauseMenu.active = false;
                    sRotateCamera.gamePaused = false;
                    Time.timeScale = 1;

                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;

                    break;
                case false:
                    pauseMenu.active = true;
                    sRotateCamera.gamePaused = true;
                    Time.timeScale = 0;

                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;

                    break;
            }
        }
    }
}
