using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SelectOrb : MonoBehaviour
{
    [SerializeField] FireOrb sFireOrb;

    public TextMeshProUGUI selectionText;

    private void Start()
    {
        selectionText.text = sFireOrb.selectedOrb.ToString();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && sFireOrb.selectedOrb != FireOrb.AmmoSelection.BLUE)
        {
            Debug.Log("Going up");
            sFireOrb.selectedOrb++;
            selectionText.text = sFireOrb.selectedOrb.ToString();
        }
        if (Input.GetKeyDown(KeyCode.Q) && sFireOrb.selectedOrb != FireOrb.AmmoSelection.RED)
        {
            Debug.Log("Going down");
            sFireOrb.selectedOrb--;
            selectionText.text = sFireOrb.selectedOrb.ToString();
        }
    }
}
