using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireOrb : MonoBehaviour
{
    public enum AmmoSelection
    {
        RED,
        GREEN,
        BLUE
    };

    public Pickup sPickup;

    public int numRedOrbs = 0;
    public int numGreenOrbs = 0;
    public int numBlueOrbs = 0;

    public AmmoSelection selectedOrb = AmmoSelection.RED;

    private float distance = 1.0f;
    private float shootForce = 2000.0f;

    [SerializeField] private Camera playerCamera;
    [SerializeField] private GameObject pRedOrb;
    [SerializeField] private GameObject pGreenOrb;
    [SerializeField] private GameObject pBlueOrb;

    private GameObject newObject;
    private Rigidbody rbNewObject;

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            switch(selectedOrb)
            {
                case AmmoSelection.RED:
                    if(numRedOrbs != 0)
                    {
                        newObject = Instantiate(pRedOrb, playerCamera.transform.position + playerCamera.transform.forward * distance, playerCamera.transform.rotation);
                        rbNewObject = newObject.GetComponent<Rigidbody>();
                        rbNewObject.AddForce(newObject.transform.forward * shootForce);

                        numRedOrbs--;
                        sPickup.redAmountText.text = numRedOrbs.ToString();
                    }
                    break;
                case AmmoSelection.GREEN:
                    if (numGreenOrbs != 0)
                    {
                        newObject = Instantiate(pGreenOrb, playerCamera.transform.position + playerCamera.transform.forward * distance, playerCamera.transform.rotation);
                        rbNewObject = newObject.GetComponent<Rigidbody>();
                        rbNewObject.AddForce(newObject.transform.forward * shootForce);

                        numGreenOrbs--;
                        sPickup.greenAmountText.text = numGreenOrbs.ToString();
                    }
                    break;
                case AmmoSelection.BLUE:
                    if (numBlueOrbs != 0)
                    {
                        newObject = Instantiate(pBlueOrb, playerCamera.transform.position + playerCamera.transform.forward * distance, playerCamera.transform.rotation);
                        rbNewObject = newObject.GetComponent<Rigidbody>();
                        rbNewObject.AddForce(newObject.transform.forward * shootForce);

                        numBlueOrbs--;
                        sPickup.blueAmountText.text = numBlueOrbs.ToString();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
