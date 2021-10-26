using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowableObject : GraableObject
{
    public float shootForce;
    private Grabber tempHand;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnHoverStart()
    {
        //base.OnHoverStart();
    }

    public override void OnHoverEnd()
    {
        //base.OnHoverEnd();
    }

    public override void OnGrabStart(Grabber hand)
    {
        base.OnGrabStart(hand);
        tempHand = hand;
    }
    public override void OnGrabEnd()
    {
        base.OnGrabEnd();
        //Shooting and this is temp
        //transform.SetParent
        GetComponent<Rigidbody>().AddForce(tempHand.transform.forward*shootForce);
        tempHand = null;

    }
}
