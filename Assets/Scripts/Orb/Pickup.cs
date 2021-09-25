using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] private GameObject pickupable;
    [SerializeField] private FireOrb sFireOrb;
    
    private void OnTriggerEnter(Collider other)
    {
        pickupable = other.gameObject;
        
        if(other.gameObject.tag == "RedOrbPickupable")
        {
            sFireOrb.numRedOrbs++;
            Destroy(pickupable);
        }
    }
}
