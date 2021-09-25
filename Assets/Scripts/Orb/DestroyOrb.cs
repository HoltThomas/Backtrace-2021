using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOrb : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Player")
        {
            Destroy(this.gameObject);
        }
        if(collision.gameObject.tag == "RedEnemy" && this.gameObject.tag == "RedOrbThrowable")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "OrbKillArea")
        {
            Destroy(this.gameObject);
        }
    }
}
