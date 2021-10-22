using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeGame : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private RotateCamera sRotateCamera;

    public void ClosePauseMenu()
    {
        pauseMenu.active = false;
        sRotateCamera.gamePaused = false;
        Time.timeScale = 1;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
