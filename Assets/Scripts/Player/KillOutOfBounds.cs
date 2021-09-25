using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOutOfBounds : MonoBehaviour
{
    [SerializeField] GameObject spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        var hasPlayerFallenToTheVoid = other.gameObject.tag == "KillArea";
        
        if (hasPlayerFallenToTheVoid)
        {
            this.transform.position = spawnPoint.transform.position;
        }
    }
}
