using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowableObject : GraableObject
{
    public float shootForce;
    private Grabber tempHand;
    private FixedJoint joint;
    private Vector3 previousPosition;

    private Queue listOfVelocity;
    // Start is called before the first frame update
    void Start()
    {
        previousPosition = transform.position;
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
        //base.OnGrabStart(hand);
        //tempHand = hand;
        joint = gameObject.AddComponent<FixedJoint>();
        //joint = gameObject.GetComponent<FixedJoint>
        joint.connectedBody = hand.GetComponent<Rigidbody>();
    }
    public override void OnGrabEnd()
    {
        //base.OnGrabEnd();
        //Shooting and this is temp
        //transform.SetParent
        //GetComponent<Rigidbody>().AddForce(tempHand.transform.forward*shootForce);
        //tempHand = null;
        Destroy(joint);

        //Calculate the velocity

        //apply the velocity

    }

    private void FixedUpdate()
    {
        //caculate a single velocity

        var velocity = transform.position - previousPosition;

        //rememberr the current position to be used in the next iteration
        previousPosition = transform.position;
    }
}
