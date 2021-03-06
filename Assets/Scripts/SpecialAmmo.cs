using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialAmmo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Only hit player
        if (other.gameObject.layer != LayerMask.NameToLayer("Player"))
            return;

        // Do stuff
        other.GetComponentInParent<Player>().AddSpecialAmmo(1);

        Destroy(gameObject);
    }
}
