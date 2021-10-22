using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDeath : MonoBehaviour
{
    [SerializeField] private GameObject spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Lava")
        {
            this.gameObject.transform.position = spawnPoint.transform.position;
        }
    }
}
