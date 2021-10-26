using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnappableObject : ThrowableObject
{
    private bool isWithinSnappableAre = false;
    private float snapZ;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("snap"))
        {
            isWithinSnappableAre = true;
            snapZ = other.transform.position.z;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("snap"))
        {
            isWithinSnappableAre = false;
        }
    }

    public override void OnGrabEnd()
    {
        base.OnGrabEnd();

        if (isWithinSnappableAre)
        {
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<Rigidbody>().useGravity = false;

            var tempPosition = new Vector3(transform.position.x, transform.position.y, snapZ);
            transform.position = tempPosition;
        }
    }

}
