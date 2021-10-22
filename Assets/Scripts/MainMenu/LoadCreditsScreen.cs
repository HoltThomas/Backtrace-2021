using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCreditsScreen : MonoBehaviour
{
    [SerializeField] private GameObject mainPage;
    [SerializeField] private GameObject creditPage;

    public void LoadCreditsPage()
    {
        mainPage.active = false;
        creditPage.active = true;
    }
}
