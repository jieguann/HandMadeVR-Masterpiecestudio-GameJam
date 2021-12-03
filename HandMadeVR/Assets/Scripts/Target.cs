using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    //public GameManager gameManager;
    public float moveSpeed;
    public float moveAmount;
    public float spinUpAmount;

    private Vector3 StartPosition;

    private GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
        manager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        var newPosition = transform.position;

        newPosition.x = StartPosition.x + Mathf.Sin(Time.time * moveSpeed) * moveAmount;
        newPosition.y = StartPosition.y + Mathf.Sin(Time.time * moveSpeed * 3) * spinUpAmount + 0.5f;
        transform.position = newPosition;
    }

    private void OnCollisionEnter(Collision collision)
    {
        var food = collision.gameObject.GetComponent<ThrowableObject>();
        if(food != null)
        {
            Destroy(food.gameObject);

            //manager.SpawnTarget();
           // manager.target[gameObject.gettag];
            Destroy(gameObject);

            // remove SOS
           

            //spawn anoter Target
        }
    }
}
