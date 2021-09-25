using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireOrb : MonoBehaviour
{
    public int numRedOrbs = 0;

    private float distance = 1.0f;
    private float shootForce = 2000.0f;

    [SerializeField] private Camera playerCamera;

    [SerializeField] private GameObject pRedOrb;

    private GameObject newObject;
    private Rigidbody rbNewObject;

    private void Update()
    {
        if(Input.GetButtonDown("Fire1") && numRedOrbs != 0)
        {
            Debug.Log("Firing stuff!");
            
            newObject = Instantiate(pRedOrb, playerCamera.transform.position + playerCamera.transform.forward * distance, playerCamera.transform.rotation);
            rbNewObject = newObject.GetComponent<Rigidbody>();
            rbNewObject.AddForce(newObject.transform.forward * shootForce);

            numRedOrbs--;
        }
    }
}
