using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float moveSpeed;
    public float moveAmount;

    private Vector3 StartPosition;

    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var newPosition = transform.position;

        newPosition.x = StartPosition.x + Mathf.Sin(Time.time * moveSpeed) * moveAmount;

        transform.position = newPosition;
    }
}
