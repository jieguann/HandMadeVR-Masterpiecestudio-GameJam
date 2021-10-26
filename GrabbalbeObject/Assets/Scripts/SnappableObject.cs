using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnappableObject : ThrowableObject
{
    private bool isWithinSnappableAre = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("snap"))
        {
            isWithinSnappableAre = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("snap"))
        {
            isWithinSnappableAre = false;
        }
    }

}
