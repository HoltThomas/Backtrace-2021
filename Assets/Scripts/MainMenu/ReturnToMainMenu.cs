using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToMainMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainPage;
    [SerializeField] private GameObject creditPage;

    public void LoadMainPage()
    {
        mainPage.active = true;
        creditPage.active = false;
    }
}
