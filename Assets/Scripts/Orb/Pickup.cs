using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pickup : MonoBehaviour
{
    [SerializeField] private GameObject pickupable;
    [SerializeField] private FireOrb sFireOrb;

    public TextMeshProUGUI redAmountText;
    public TextMeshProUGUI greenAmountText;
    public TextMeshProUGUI blueAmountText;

    private void OnTriggerEnter(Collider other)
    {
        pickupable = other.gameObject;
        
        if(other.gameObject.tag == "RedOrbPickupable")
        {
            sFireOrb.numRedOrbs++;
            redAmountText.text = sFireOrb.numRedOrbs.ToString();
            Destroy(pickupable);
        }
        if (other.gameObject.tag == "GreenOrbPickupable")
        {
            sFireOrb.numGreenOrbs++;
            greenAmountText.text = sFireOrb.numGreenOrbs.ToString();
            Destroy(pickupable);
        }
        if (other.gameObject.tag == "BlueOrbPickupable")
        {
            sFireOrb.numBlueOrbs++;
            blueAmountText.text = sFireOrb.numBlueOrbs.ToString();
            Destroy(pickupable);
        }
    }
}
